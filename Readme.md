<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581647/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1296)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to change cell appearance depending on a hidden column value


<p>This example demonstrates how to change cell appearance based on a data column that doesn't have a corresponding field. To accomplish this task, you should handle the <strong>CustomDrawCell</strong> event. You don't have to perform your own custom drawing when handling this event. It allows you to change cell appearance without any custom draw actions. You shouldn’t set the <strong>e.Handled</strong> property to true to perform appearance change without any custom drawing.</p><p>To get rows that represent the current cell, call the <strong>CreateDrillDownDataSource</strong> method. Use the <strong>GetValue</strong> method to obtain a particular cell value.</p>

<br/>


