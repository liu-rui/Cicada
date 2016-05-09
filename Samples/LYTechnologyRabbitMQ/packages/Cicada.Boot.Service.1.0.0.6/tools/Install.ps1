param($installPath, $toolsPath, $package, $project)

$configItem = $project.ProjectItems.Item("Service.cs")

$copyToOutput = $configItem.Properties.Item("CopyToOutputDirectory")
$copyToOutput.Value = 0

$buildAction = $configItem.Properties.Item("BuildAction")
$buildAction.Value = 1

