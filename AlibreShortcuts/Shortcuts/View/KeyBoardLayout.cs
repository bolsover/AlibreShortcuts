using System.Collections;
using System.Xml;

namespace Shortcuts.Shortcuts.View
{
    public class KeyBoardLayout
    {
        public ArrayList KeyProperties { get; set; }


        private void ReadXmlKeyProperties()
        {
           XmlDocument doc = new XmlDocument();
           doc.Load("KeyProperties.xml");
           
           
           
        }
        
    }
}