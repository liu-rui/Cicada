
### 这是有关WebApi类型项目的介绍，使用主要注意一下几点：
	
  * 1 WebApi项目，通过NuGet程序包搜索“Cicada”，在结果里面有一个"Cicada.Boot.Aspnet.WebApi",安装到WebApi项目即可。
  * 2 在项目中找到Cicada.properties文件，打开编辑其中对应的链接即可，具体介绍如下：
     * 2.1 Cicada.DI.AutoRegisterByProductName对应Service层的名字字符串，前面#号去掉（有#号就是注释的意思）。
     * 2.2 Cicada.Data.Provider默认支持MySql，如果使用SqlServer，就把前面的注释去掉，对应的名字改成SqlServer。
     * 2.3 Cicada.Data.ConnectionString这个按照实际数据链接情况更改即可。
  * 3 Server层，同样通过NuGet程序包搜索“Cicada”,里面有一个“Cicada.Data.EntityFramework”,点击按照即可，里面具体配置如下：
     * 3.1 右键点击通过“Entity Framework”这项生成对应的EF数据映射和数据实体模型（得安装EF Power Tool和对应的数据库驱动）
     * 3.2 然后数据的具体实现可以参考下载的程序。
