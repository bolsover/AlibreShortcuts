 * DISCLAIMER:
 * ALL SOURCE CODE IN THIS PROJECT IS PROVIDED BY ALIBRE, LLC FOR
 * DEMONSTRATION PURPOSES ONLY AND ANY EXPRESSED OR IMPLIED WARRANTIES
 * ARE DISCLAIMED. IN NO EVENT SHALL ALIBRE INC. BE LIABLE FOR ANY 
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL 
 * DAMAGES ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE.

IMPORTANT: This sample requires Alibre Design version 2019 or later

INSTRUCTIONS FOR BUILDING, INSTALLING & RUNNING the Sample Add-on for using DXDevice for rendering.
===================================================================================================

1. Open ADSampleAddOnDX.sln in Microsoft Visual Studio (this sample was last built with Visual Studio 2022 and tested on Alibre Design V29)

2. Open the include file StdAfx.H. Change the line that reads #import "AlibreX_64.TLB" to include the full folder path of AlibreX_64.DLL on your machine (usually C:\Program Files\Alibre Design\Program\AlibreX_64.TLB).

   Similarly, modify the line that reads #include "AlibreAddOn_64.TLB" to include the full folder path (usually same as the above).

3. Save changes by clicking the File->Save menu command.

4. Next, make sure the active configuration is "Debug - x64" or "Release - x64". Select "Build->Rebuild All" command from menu to build this C++ project.
This will create the DLL ADSampleAddOnDX.DLL under "x64\Debug" (or, "x64\Release") folder. This DLL is meant to be loaded in Alibre Design's runtime process (see next step)

5. We are now ready to install the built add-on in its final delivery location:

	a. In Windows Explorer, navigate to your "ProgramData" folder (%PROGRAMDATA%). There, create a subfolder named "Alibre AddOns" if it does not already exist. Below this sub folder, create a new sub folder named "ADSampleAddOnDX"

	b. Next copy the following files from the C++ project folder to the new folder you just created (see above step):

		i)  ADSampleAddOnDX.dll -- we created this dll in step 4; it should find it under the .\x64\Release sub-folder.
		ii) ADSampleAddOn.adc -- this is the add-on configuration file; check it out using NotePad.
		iii)ADSampleAddon.ico -- add-on's custom icon used in Alibre's Add-on Manager
		iv) Wood.jpg -- image file used by add-on's command that draws a textured mesh (V2019 and later only)
  
6. Review the ADSampleAddOn.adc file from the above step using a text editor like NotePad. This adc file has been pre-created for this sample. 
Note that each add-on needs a GUID to uniquely identify it. Close the file without making any changes.

7. Using a Windows registry viewer like RegEdit.EXE :

	- Navigate to the following registry key:
	  "HKEY_LOCAL_MACHINE\SOFTWARE\Alibre Design Add-Ons"

	- Add a new String Value under this key.

	- Set the Value Name to:  {D05E1217-21A7-4e37-A302-398AA1BDDD7E}

	  Note: This should match entry in ADSampleAddOnDX.adc file.

	- Set the Value Data to the addon's installation folder (see step 5a above). Example:
	  C:\ProgramData\Alibre AddOns\ADSampleAddOnDX

	- Close Registry

8. To run this Add-on:

	- Launch Alibre Design

	- Open the part file: .\Data\TestPart1.AD_PRT. It is supplied with this AddOn Sample
	  add-on project.

	- On the ribbon interface, click the "Add-Ons" tab. You should see the "DX Triangle" button there.
	  If not, click on "Add-on Manager". You should see the "Sample Addon - DX Triangle" on the Add-on Manager dialog.
	  Make sure it is enabled by selecting the check box next to it.

	- From the "DX Triangle" pull down menu, click on the "Post Render" command.
	  Notice a Triangle drawn on View along with the model. Press any keyboard key to
	  translate the triangle by an offset along X; press Escape key to terminate command.
	  This demonstrates how both Alibre Design and the sample addon can draw their graphics
	  on the graphics window.

	- From the "DX Triangle" pull down menu, click on the "Override Render" command.
	  Notice a Triangle drawn on Cleared View port with overridden rendering.
	  This demonstrates how sample addon can draw its graphics while suppressing Alibre Design's
	  graphics.

9. Browse the source codes to check out the add-on's implementation. The important ones are:
	- CSampleAddOnInterface.cpp: The class 'CSampleAddOnInterface' implements relevant methods of IAlibreAddOn interface
	- DrawTriangleCommand.cpp: The class 'CDrawTriangleCommand' implements relevant methods of IAlibreAddOnCommand interface

For more details on implementing tightly integrated addons, read Integrated_Addons_in_Alibre Design.pdf (distributed separately).

======================================================================================================