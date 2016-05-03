
### 这是有关Window服务打包类型项目的介绍，使用主要注意以下几点：
	
  * 1 示例项目为一般处理程序，名字为WindowService；搜索安装Cicada.Boot.Service。
  * 2 在WindowService项目中找到Cicada.properties文件，具体操作如下：
     * 2.1 Cicada.DI.AutoRegisterByProductName对应WindowService层的名字字符串，前面#号去掉（有#号就是注释的意思）。
     * 2.2 配置好Cicada.Boot.Service.Name、Cicada.Boot.Service.DisplayName、Cicada.Boot.Service.Description项即可。
     * 2.3 安装服务为进入对应项目的bin/Debug文件下，Dom窗口执行(项目名称.exe) install 命令即可安装上，卸载项目名称.exe unInstall。
	 * 2.4 在系统服务中找到对应的服务项，启动即可。
