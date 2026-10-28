 * DISCLAIMER:
 * ALL SOURCE CODE IN THIS PROJECT IS PROVIDED BY ALIBRE INC. FOR
 * DEMONSTRATION PURPOSES ONLY AND ANY EXPRESSED OR IMPLIED WARRANTIES
 * ARE DISCLAIMED. IN NO EVENT SHALL ALIBRE INC. BE LIABLE FOR ANY 
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL 
 * DAMAGES ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE.

INSTRUCTIONS FOR BUILDING, INSTALLING & RUNNING the Animation Sample Add-on
===========================================================================

1. Open SampleAddOn.sln in Microsoft Visual Studio (this sample was last built with Visual Studio 2022 and tested on Alibre Design V29)


2. Open the include file StdAfx.H. Change the line that reads #import "C:Program Files\Alibre Design\Program\AlibreX_64.tlb" to include the actual file path of AlibreX_64.tlb on your machine. This is usually C:Program Files\Alibre Design\Program unless you installed Alibre Design in a different location.

Similarly, modify the line that reads #import "C:\Program Files\Alibre Design\Program\AlibreAddOn_64.tlb".


3. Save changes by clicking the File->Save menu command.


4. Next, make sure the Active Solution Configuration is "Release" and the Active Solution Platform is "x64". Choose "Build->Rebuild Solution" command from the menu bar to build the sample Addon. This will create the DLL SampleAddOn.DLL under "Release" folder. This DLL is meant to be loaded in Alibre Deisgn's runtime process.


5. We are now ready to install the built add-on in its final delivery location:

	a. In Windows Explorer, navigate to your "ProgramData" folder (%PROGRAMDATA%). There, create a subfolder named "Alibre AddOns" if it does not already exist. Finally, below this sub folder, create a new sub folder named "AnimationAddOn".

	b. Next copy the following files from the addon's project folder to the new folder (i.e., %PROGRAMDATA%\Alibre AddOns\AnimationAddOn) that you just created:

		i)  SampleAddOn.dll -- see step 4
		ii) SampleAddOn.adc -- this is the add-on configuration file
		iii)SampleAddon.ico -- add-on's custom icon used in Alibre's Add-on Manager

  
6. Review the SampleAddOn.adc file from the above step using a text editor like NotePad. This adc file has been pre-created for this sample. Note that each add-on needs a GUID to uniquely identify it. Close the file without making any changes.


7. Using a Windows registry viewer like RegEdit.EXE :

	- navigate to the following registry key:
	  "HKEY_LOCAL_MACHINE\SOFTWARE\Alibre Design Add-Ons"

	- Add a new String Value under this key.

	- Set the Value Name to:
	  {B54F7B88-BECD-46af-8E70-651DEBB180A9}
	  Note: This should match entry in SampleAddOn.adc file.

	- Set the Value Data to the addon's installation folder. In this expample, this would be:
	  C:\ProgramData\Alibre AddOns\AnimationAddOn

	- Close Registry
	  


8. To run this Add-on:

	- Launch Alibre Design

	- Open the assembly file, ".\Data\TestAsm.AD_ASM", that is delivered with this add-on project.
	  Note that this assembly model has been tailored to work for this sample.

	- Click 'Tools->Add-on Manager' menu item.
	  You should see the "Animation Sample" on the Add-on Manager dialog.
	  Make sure it is enabled by selecting the check box next to it.

	- See the add-on's menu "My Animation" appear on Alibre Design's menu bar.

	- From the "My Animation" pull down menu, click on the "Activate UI" command.

	- Using the mouse select the planar face on "TestPart1" that is flush with the planar face on "TestPart2".

	- From the "My Animation" pull down menu, click on the "Define Motion" command.
	  Notice some new GUI controls are shown on the Explorer pane.

	- Enter 10 for 'Number of Frames". Then click Apply. Notice the motion being captured.
	  This demonstrates both Alibre Design and the sample addon drawing simultaneously on the graphics window.

	- From the "My Animation" pull down menu, click the "Start Animation" command.
	  Notice some new GUI controls are shown on the Explorer pane.

	- Click the 'ANIMATE' button. See animation playback.
	  This demonstrates add-on alone drawing on the graphics window after suppressing Alibre's display.

	- Click the 'EXIT' button to exit the playback mode.
	  At this point add-on stops drawing on the graphics window and restores regular (Alibre's) display.

	- From the "My Animation" pull down menu, click the "Summary" command.
	  See the interference volumes getting displayed on a NotePad window.

	- Finally, from the "My Animation" pull down menu, click on the "Activate UI" command. This will now deactivate the add-on.

NOTE:
For techincal details on implementing such add-ons, read Integrated_Addons_in_Alibre Design.pdf (distributed separately).

To grasp how some key functions/intefaces described there are implemented in this sample, examine the following source files:

	* DLL Exported Function GetAddOnInterface() - SampleAddOn.H and SampleAddOn.CPP
	* Interface IAlibreAddOn – CSampleAddOnInterface.H (with its implementation in CSampleAddOnInterface.CPP)
	* Method IAlibreAddOn::InvokeCommand()  – CsampleAddOnInterface.CPP
	* Method IAlibreAddOnCommand::AddTab() – CShowUICommand.H and CShowUICommand.CPP
	* Method IAlibreAddOnCommand::OnShowUI() – CShowUICommand.CPP
	* Method IAlibreAddOnCommand::OnRender() – CDefineAnimationCommand.CPP  and CStartAnimationCommand.CPP
	* Method IADAddOnCommandSite::UpdateCanvas() – CDefineAnimationCommand.CPP
	* Method IADAddOnCommandSite::OverrideRender() – CStartAnimationCommand.CPP

This add-on sample does not persist any custom data to the file. So, it does not implement SaveData() and LoadData().
