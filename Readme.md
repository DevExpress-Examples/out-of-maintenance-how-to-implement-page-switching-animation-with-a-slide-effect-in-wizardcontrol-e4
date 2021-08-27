<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128639267/12.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4346)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [ucDocMetro.cs](./CS/ucDocMetro.cs) (VB: [ucDocMetro.vb](./VB/ucDocMetro.vb))
* [ucSlideWizard.cs](./CS/ucSlideWizard.cs) (VB: [ucSlideWizard.vb](./VB/ucSlideWizard.vb))
<!-- default file list end -->
# How to implement page switching animation with a slide effect in WizardControl.


<p>     Page switching animation in a <strong>WizardControl </strong>can be implemented with a slide effect like Documents that are switched in the <strong>PageGroup </strong>container of the <strong>MetroUI </strong>view. For  this purpose, we use the <strong>DocumentManager </strong>with the <strong>MetroUIView</strong>. The main idea here is to create a PageGroup with documents and show a particular <strong>WizardControl </strong>page within a <strong>Document</strong>. </p><p>     The current example contains two UserControls: </p><p><strong><u>ucDocMetro </u></strong>– contains the <strong>DocumentManager</strong>;</p><p><strong><u>ucSlideWizard </u></strong>– contains <strong>ucDocMetro </strong>and navigation buttons. This control also allows you to customize the <strong>WizardControl </strong>that will be used in the <strong>DocumentManager</strong>.</p><p><strong>See also:</strong><strong> </strong><a href="https://www.devexpress.com/Support/Center/p/Q502681">How to create Wizard application using WindowsUIView?</a></p>

<br/>


