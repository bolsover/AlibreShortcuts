using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Bolsover.Shortcuts.Model;

namespace Bolsover.Shortcuts.Calculator
{
    public class ShortcutsHtmlReport
    {
        public string BuildHtmlReport(string profile)
        {
            string html = null;
            ShortcutsCalculator calculator = new();

            ArrayList userShortcuts = calculator.RetrieveUserShortcutsByProfile(profile);

            if (userShortcuts.Count > 0)
            {
                ArrayList standardShortcuts = calculator.RetrieveStandardShortcuts();
                Dictionary<string, Shortcut> standardShortcutsDict = calculator.ShortcutsDictionary(standardShortcuts);
                int tables = userShortcuts.Count / 20;
                string table = ToAbbreviatedTable(userShortcuts, standardShortcutsDict);
                if (tables > 1)
                {
                    List<XmlElement> xmlElements = SplitXmlTable(table, tables);
                    StringBuilder sb = new();
                    foreach (var element in xmlElements)
                    {
                        sb.Append(element.OuterXml);
                    }

                    html = AddHtmlHeaderFooter(sb.ToString(), profile);
                }
                else
                {
                    html = AddHtmlHeaderFooter(table, profile);
                }
            }
            else
            {
                ArrayList standardShortcuts = calculator.RetrieveStandardShortcutsByProfile(profile);

                int tables = standardShortcuts.Count / 20;
                string table = ToAbbreviatedTable(standardShortcuts);
                if (tables > 1)
                {
                    List<XmlElement> xmlElements = SplitXmlTable(table, tables);
                    StringBuilder sb = new();
                    foreach (var element in xmlElements)
                    {
                        sb.Append(element.OuterXml);
                    }

                    html = AddStandardHtmlHeaderFooter(sb.ToString(), profile);
                }
                else
                {
                    html = AddStandardHtmlHeaderFooter(table, profile);
                }
            }

            return html;
        }

        private string ToAbbreviatedTable(ArrayList standardShortcuts)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table>");
            sb.Append("<tr>");
            sb.Append("<th>");
            sb.Append("Hint");
            sb.Append("</th>");
            sb.Append("<th>");
            sb.Append("Shortcut");
            sb.Append("</th>");
            sb.Append("</tr>");
            foreach (Shortcut sc in standardShortcuts)
            {
                sb.Append("<tr>");
                sb.Append("<td>");
                sb.Append(sc.Hint);
                sb.Append("</td>");
                sb.Append("<td>");
                sb.Append(sc.KeyChar);
                sb.Append("</td>");
                sb.Append("</tr>");
            }

            sb.Append("</table>");

            return sb.ToString();
        }

        private List<XmlElement> SplitXmlTable(string xmlContent, int n)
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlContent);

            var tableNode = document.DocumentElement;

            if (tableNode == null)
                throw new Exception("No table found in the provided XML");

            var rows = tableNode.ChildNodes;
            var rowsPerTable = (int) Math.Ceiling((double) (rows.Count - 1) / n); // Subtract 1 for the  header row
            var tables = new List<XmlElement>();

            for (var i = 0; i < n; i++)
            {
                XmlDocument doc = new XmlDocument();
                var newTable = (XmlElement) doc.AppendChild(doc.CreateElement("Table"));

                // Add the top row to each new table
                if (rows.Count > 0)
                {
                    var cloneRow1 = rows[0].CloneNode(true);

                    newTable.AppendChild(doc.ImportNode(cloneRow1, true));
                }

                for (var j = i * rowsPerTable + 1; j < (i + 1) * rowsPerTable + 1 && j < rows.Count; j++) // Start at row 2 for each new table
                {
                    var cloneRow = rows[j].CloneNode(true);
                    newTable.AppendChild(doc.ImportNode(cloneRow, true));
                }

                tables.Add(newTable);
            }

            return tables;
        }

        private string ToAbbreviatedTable(ArrayList shortcuts, Dictionary<string, Shortcut> standardShortcuts)
        {
            StringBuilder sb = new StringBuilder();
            Shortcut priorShortcut = null;

            foreach (Shortcut sc in shortcuts)
            {
                Shortcut standardShortcut = null;
                if (standardShortcuts.ContainsKey(sc.Profile + "." + sc.Command))
                {
                    standardShortcut = standardShortcuts[sc.Profile + "." + sc.Command];
                }

                if (standardShortcut != null && standardShortcut.KeyChar == sc.KeyChar)
                {
                    sc.ShortcutType = ShortcutType.Default;
                }

                if (standardShortcut != null && standardShortcut.KeyChar != sc.KeyChar)
                {
                    sc.ShortcutType = ShortcutType.Override;
                }

                if (standardShortcut == null)
                {
                    sc.ShortcutType = ShortcutType.Custom;
                }


                if (priorShortcut == null | (priorShortcut != null && priorShortcut.Profile != sc.Profile))
                {
                    sb.Append("<table>");
                    sb.Append("<tr>");
                    sb.Append("<th>");
                    sb.Append("Hint");
                    sb.Append("</th>");
                    sb.Append("<th>");
                    sb.Append("Shortcut");
                    sb.Append("</th>");
                    sb.Append("</tr>");
                }
                else
                {
                    if (!string.IsNullOrEmpty(sc.Hint))
                    {
                        switch (sc.ShortcutType)
                        {
                            case ShortcutType.Default:
                                sb.Append("<tr>");
                                break;
                            case ShortcutType.Custom:
                                sb.Append("<tr style=\"color:#0000ff\">");
                                break;
                            case ShortcutType.Override:
                                sb.Append("<tr style=\"color:#ff0000\">");
                                break;
                        }

                        sb.Append("<td>");
                        sb.Append(sc.Hint);
                        sb.Append("</td>");
                        sb.Append("<td>");
                        sb.Append(sc.KeyChar);
                        sb.Append("</td>");
                        sb.Append("</tr>");
                    }
                }

                priorShortcut = sc;
            }

            sb.Append("</table>");

            return sb.ToString();
        }

        private string AddHtmlHeaderFooter(string html, string profile)
        {
            var header =
                @"<html><head><style>  table, th, td {  border: 1px solid black;  border-collapse: collapse;  }  th, td {  padding: 5px;  text-align: left;  }  </style>
<style> table {float:left; margin-left: 5px; margin-right: 5px;} </style>
</head><body><p><span style = ""color:black"">Black - Standard Shortcut </span>
<span style = ""color:red"">Red - Overridden Standard </span>
<span style = ""color:blue"">Blue - Custom Shortcut </span> </p>
<p><b>Profile: <span style = ""color:black"">" + profile + @"</span></b></p>
<div style=""display: inline-block"">";
            var footer = @"</div></body></html>";
            return header + html + footer;
        }

        private string AddStandardHtmlHeaderFooter(string html, string profile)
        {
            var header =
                @"<html><head><style>  table, th, td {  border: 1px solid black;  border-collapse: collapse;  }  th, td {  padding: 5px;  text-align: left;  }  </style>
<style> table {float:left; margin-left: 5px; margin-right: 5px;} </style>
</head><body><p><b><span style = ""color:black"">No Custom Shortcuts found, showing Standard Shortcuts only. </span></b></p>
<p><b><span style = ""color:black"">To assign Custom Shortcuts use the System Options | All Workspaces | Keyboard Shortcuts dialog. </span></b></p>
<p><b>Profile: <span style = ""color:black"">" + profile + @"</span></b></p>
<div style=""display: inline-block"">";
            var footer = @"</div></body></html>";
            return header + html + footer;
        }
    }
}