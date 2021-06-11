# TestMyXmlParser
This is a plug-in example with xml text parsing capabilities that can be easily and efficiently used in unreal engine blueprints

The plugin project link: https://www.unrealengine.com/marketplace/en-US/product/2884482d7e534f218fb4a39626f6b54b

How to use:
1. Prepare the example project TestMyXmlParser and the plugin project MyXmlParser
2. Use UE4Editor of 4.22 or higher version to open the .uproject file under the directory of TestMyXmlParser
3. Before running the example in windows system, utf8test.xml needs to be copied to C disk (if it is other operating system, the Path value of LoadFile node needs to be changed to the corresponding value of the xml file under the system). The location of LoadFile node is located in the Event Graph in the blueprint of BP_testXmlParser
