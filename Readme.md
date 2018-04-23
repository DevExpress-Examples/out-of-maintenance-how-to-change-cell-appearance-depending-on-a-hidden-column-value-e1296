# How to change cell appearance depending on a hidden column value


<p>This example demonstrates how to change cell appearance based on a data column that doesn't have a corresponding field. To accomplish this task, you should handle the <strong>CustomDrawCell</strong> event. You don't have to perform your own custom drawing when handling this event. It allows you to change cell appearance without any custom draw actions. You shouldn’t set the <strong>e.Handled</strong> property to true to perform appearance change without any custom drawing.</p><p>To get rows that represent the current cell, call the <strong>CreateDrillDownDataSource</strong> method. Use the <strong>GetValue</strong> method to obtain a particular cell value.</p>

<br/>


