
#### 一、这是有关授权认证集成的介绍，使用主要注意以下几点：
- 1 WebApi类型项目通过NuGet程序包安装*LY.UserAuthorize*（与之前使用的模块互补影响），参考下图：  
![Alt text](1464750649625.png)
- 2 修改配置文件*Cicada.DI.AutoRegisterByProductName*，将当前项目的程序集名称（[assembly: AssemblyProduct("WebApiAuth")]）也添加到*注册类型里面*，参考图像如下：  
![Alt text](1464750891765.png)
- 3 在控制器(ApiController)添加类特性，参考图像如下：  
 ![Alt text](1464751005286.png)
 - 4 如何想获取当前用户UserId，通过构造函数注入获取用户Id的上下文，注入方式如下：
 ![Alt text](1464751154383.png)
- 5 通过用户上下文获取用户Id，参考图像如下：
 ![Alt text](1464751209727.png)
- 6 开发调试阶段在Swagger调试工具上输入要模拟的UserId，参考图像如下：
 ![Alt text](1464751361338.png)


####二、上述操作是在开发阶段，Mock出来的用户Id，如果上线的话，如何配置？请参考下面：
- 7 在配置文件*LY.UserAuthorize*修改如何配置即可，其他地方不需要修改！！！
![Alt text](1464751948997.png)





