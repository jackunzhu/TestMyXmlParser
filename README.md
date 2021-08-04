# TestMyXmlParser

这是一个带有xml文本解析功能的插件示例，可以轻松有效地在虚幻引擎蓝图中使用  
This is a plug-in example with xml text parsing capabilities that can be easily and efficiently used in unreal engine blueprints

插件项目链接：https://www.unrealengine.com/marketplace/en-US/product/2884482d7e534f218fb4a39626f6b54b
The plugin project link: https://www.unrealengine.com/marketplace/en-US/product/2884482d7e534f218fb4a39626f6b54b


使用方法：  
1. 准备好示例工程TestMyXmlParser和插件工程MyXmlParser  
2. 拷贝MyXmlParser目录到TestMyXmlParser目录下的Plugins目录中（如果Plugins目录不存在则需要新建Plugins目录）  
3. 使用4.22版本或更高版本的UE4Editor打开TestMyXmlParser目录下的uproject文件即可  
4. 如果在windows系统下出现编译错误，请在uproject文件上点击鼠标右键菜单中的"Generate visual studio project files"来生成visual studio解决方案，再使用visual studio 2017或更高版本编译工程，如果在macos系统下出现编译错误，则使用xcode编译，再使用UE4Editor打开uproject文件  
5. 在windows系统中运行测试前需要将utf8test.xml拷贝到C盘下（如果是其他操作系统则需要修改LoadFile节点的Path值为系统下该xml文件对应的路径), LoadFile节点的位置位于BP_testXmlParser蓝图中的Event Graph中  

How to use:
1. Prepare the example project TestMyXmlParser and the plugin project MyXmlParser
2. Copy the MyXmlParser directory to the Plugins directory under TestMyXmlParser (create a Plugins directory if the Plugins directory does not exist).  
3. Use UE4Editor version 4.22 or later to open the uproject file under the directory of TestMyXmlParser
4. If a compilation error occurs on Windows, right-click the uproject file and click "Generate Visual Studio Project Files "to Generate the Visual Studio solution. Use Visual Studio 2017 or later to compile the project. If there is a compilation error on MacOS, use Xcode to compile the project, and then use UE4Editor to open the uproject file
5. Before running the test on Windows, copy utf8test.xml to drive C (for other operating systems, change the Path of the LoadFile node to the corresponding Path of the xml file). The location of the LoadFile node is in the Event Graph of the BP_testXmlParser blueprint
