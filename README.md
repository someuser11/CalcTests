# CalcTests
Test example

# How to run
Use NUnit Console Runner with command like:
nunit3-console "D:\CalcTests\CalcTests\bin\Debug\CalcTests.dll" --params=DefaultWaitTimeout="60000";PageLocatorsDirectory="D:\CalcTests\CalcTests\Pages\XmlLocators";CalcExpressionPath="D:\CalcTests\CalcTests\TestExpressions.xml";ScreenshotDirectory="D:\CalcTests\Screenshots";Drivers="Chrome,Gecko"

These tests will use 'App.config' file as parameters if there's no parameteres in the command line.

# Calc epressions
Calc epressions as test parameters located in TestExpressions.xml.

# TestExplorer
![test_screenshot](https://user-images.githubusercontent.com/46107792/50403067-1daf1800-07b5-11e9-9470-97c1835aa69d.png)
