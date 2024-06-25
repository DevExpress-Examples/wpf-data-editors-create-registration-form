<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128644289/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4575)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Editors - Create a Registration Form

This example is the application from the [Create a Registration Form](https://docs.devexpress.com/WPF/17675/controls-and-libraries/data-editors/getting-started/how-to-create-a-registration-form) tutorial. The solution includes projects for each completed tutorial step.

## BaseProject

This project is a draft application connected to a database. The project contains two predefined views: **MainView** with the [DXTabControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Core.DXTabControl) and **RecordsView** with the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl):

### Files to Review

* [MainView.xaml](./CS/RegistrationForm.BaseProject/View/MainView.xaml) (VB: [MainView.xaml](./VB/RegistrationForm.BaseProject/View/MainView.xaml))
* [MainViewModel.cs](./CS/RegistrationForm.BaseProject/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/RegistrationForm.BaseProject/ViewModel/MainViewModel.vb))
* [RecordsView.xaml](./CS/RegistrationForm.BaseProject/View/RecordsView.xaml) (VB: [RecordsView.xaml](./VB/RegistrationForm.BaseProject/View/RecordsView.xaml))
* [RecordsViewModel.cs](./CS/RegistrationForm.BaseProject/ViewModel/RecordsViewModel.cs) (VB: [RecordsViewModel.cs](./CS/RegistrationForm.BaseProject/ViewModel/RecordsViewModel.cs))

### Documentation

* [Starting Point](https://docs.devexpress.com/WPF/17676/controls-and-libraries/data-editors/getting-started/how-to-create-a-registration-form/starting-point)

## Lesson1

This project uses the [LayoutControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.LayoutControl.LayoutControl) to arrange data editors within the **RegistrationView**:

![image](https://user-images.githubusercontent.com/65009440/226887933-cb473803-3931-423a-b3f0-1b46ccff0043.png)

### Files to Review

* [RegistrationView.xaml](./CS/RegistrationForm.Lesson1/View/RegistrationView.xaml) (VB: [RegistrationView.xaml](./VB/RegistrationForm.Lesson1/View/RegistrationView.xaml))

### Documentation

* [Lesson 1 - Create Layout](https://docs.devexpress.com/WPF/17677/controls-and-libraries/data-editors/getting-started/how-to-create-a-registration-form/lesson-1-create-layout)

## Lesson2

This project binds data editors to View Model properties:

![image](https://user-images.githubusercontent.com/65009440/226891620-ca537443-6c9f-4430-bb56-4efec69eb25c.png)

### Files to Review

* [RegistrationView.xaml](./CS/RegistrationForm.Lesson2/View/RegistrationView.xaml) (VB: [RegistrationView.xaml](./VB/RegistrationForm.Lesson2/View/RegistrationView.xaml))
* [RegistrationViewModel.cs](./CS/RegistrationForm.Lesson2/ViewModel/RegistrationViewModel.cs) (VB: [RegistrationViewModel.cs](./CS/RegistrationForm.Lesson2/ViewModel/RegistrationViewModel.cs))

### Documentation

* [Lesson 2 - Bind Data Editors](https://docs.devexpress.com/WPF/17689/controls-and-libraries/data-editors/getting-started/how-to-create-a-registration-form/lesson-2-bind-data-editors)

## Lesson3

This project defines data editor settings (null text, mask, min and max values, popup mode, and data source):

![image](https://user-images.githubusercontent.com/65009440/226893095-3ea7bad1-56a8-45b9-a39e-8fd72c5e0373.png)

### Files to Review

* [RegistrationView.xaml](./CS/RegistrationForm.Lesson3/View/RegistrationView.xaml) (VB: [RegistrationView.xaml](./VB/RegistrationForm.Lesson3/View/RegistrationView.xaml))
* [RegistrationViewModel.cs](./CS/RegistrationForm.Lesson3/ViewModel/RegistrationViewModel.cs) (VB: [RegistrationViewModel.cs](./CS/RegistrationForm.Lesson3/ViewModel/RegistrationViewModel.cs))

### Documentation

* [Lesson 3 - Customize Editors](https://docs.devexpress.com/WPF/17690/controls-and-libraries/data-editors/getting-started/how-to-create-a-registration-form/lesson-3-customize-editors)

## Lesson4

This project uses [ValidationRules](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.validationrule) to implement input validation and disables the **Register** button if editors contain validation errors:

![image](https://user-images.githubusercontent.com/65009440/226896243-cf9cae10-b14e-4b5f-a1ec-e40a0e224911.png)

### Files to Review

* [RegistrationView.xaml](./CS/RegistrationForm.Lesson4/View/RegistrationView.xaml) (VB: [RegistrationView.xaml](./VB/RegistrationForm.Lesson4/View/RegistrationView.xaml))
* [ValidationRules.cs](./CS/RegistrationForm.Lesson4/Common/ValidationRules.cs) (VB: [ValidationRules.vb](./VB/RegistrationForm.Lesson4/Common/ValidationRules.vb))

### Documentation

* [Lesson 4 - Implement Input Validation using ValidationRules](https://docs.devexpress.com/WPF/17693/controls-and-libraries/data-editors/getting-started/how-to-create-a-registration-form/lesson-4-implement-input-validation-using-validationrules)

## Lesson5

This project uses the [IDataErrorInfo](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.idataerrorinfo) interface to obtain validation errors and displays a [message box](https://docs.devexpress.com/WPF/17415/mvvm-framework/services/predefined-set/message-box-services/dxmessageboxservice) with the registration result:

![image](https://user-images.githubusercontent.com/65009440/226903130-3d2362ae-b947-4fdc-84f1-eb718d364ff1.png)

### Files to Review

* [RegistrationView.xaml](./CS/RegistrationForm.Lesson5/View/RegistrationView.xaml) (VB: [RegistrationView.xaml](./VB/RegistrationForm.Lesson5/View/RegistrationView.xaml))
* [RegistrationViewModel.cs](./CS/RegistrationForm.Lesson5/ViewModel/RegistrationViewModel.cs) (VB: [RegistrationViewModel.vb](./CS/RegistrationForm.Lesson5/ViewModel/RegistrationViewModel.cs))
* [MainView.xaml](./CS/RegistrationForm.Lesson5/View/MainView.xaml) (VB: [MainView.xaml](./VB/RegistrationForm.Lesson5/View/MainView.xaml))

### Documentation

* [Lesson 5 - Implement Input Validation using IDataErrorInfo](https://docs.devexpress.com/WPF/17694/controls-and-libraries/data-editors/getting-started/how-to-create-a-registration-form/lesson-5-implement-input-validation-using-idataerrorinfo)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-editors-create-registration-form&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-editors-create-registration-form&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
