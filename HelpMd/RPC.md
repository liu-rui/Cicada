
### 这是有关RPC类型项目的介绍，其中包括RPC服务（Server）和RPC客户端（Client）：
	一、RPC服务端的介绍：
		* 1.1、RPC服务端项目类型是一般处理程序；通过NuGet包引用下载的程序包括Cicada.Boot和Cicada.Rpc，因为用的是一般处理程序，
			最后要打包成系统服务，所以也引用Cicada.Boot.Service。
		* 1.2、添加一个用来处理具体业务的文件夹，我们命名为Services，这个里面存放我们服务端要实现的功能文件（包括要生成的对外接口和
			要实现的对外接口功能），生成接口方法依次顺序：a.找到项目绝对路径“\packages\Cicada.Rpc.1.0.0.5\tools”，打开编辑demo.thrift
			（这里面定义的是服务端对外开放的数据接口）定义完成后保存；b.双击执行生成c#代码.bat文件；c.然后就可以把gen-csharp文件里的
			数据拷贝到刚才创建的Service文件里。
		* 1.3、在Service文件里创建一个继承自Thrift***.Iface,然后对上面生成的接口进行实现。
		* 1.4、最后要配置的就是Cicada.properties。首先配置AutoRegisterByProductName；因为要打包成系统服务，Windows Service项要配置
			对应的信息；然后就是RPC服务器端相关配置，具体如何配置请参看配置说明。
	
	
	二、RPC客户端的介绍：
		* 2.1、RPC的客户端示例用的也是一般处理程序，要引用的程序包包含Cicada.Boot和Cicada.Rpc。
		* 2.2、同样创建Service文件夹，这里放置的依然是生成的接口文件。
		* 2.3、最后就是配置Cicada.properties。首先还是AutoRegisterByProductName；然后就是RPC客户端相关配置信息，根据配置说明
			填写对应信息。
		
		
	三、RPC定义接口模板示例：
			struct Customer {   #  定义客户类
				1: i32 customerId   #客户编码
				2: string name		#客户名称
				3: Address addressInfo	#地址信息
			}

			struct	Address{	#地址类
				1: string city	#城市
				2: string street	#街道
			}
			  
			service ThriftCustomerService {  #  定义服务接口
				i32 Add(1:Customer customer)	#添加一个客户，返回新客户编码
				Customer Get(1:i32 id)			#根据客户编码获取指定客户信息
				list<Customer> GetList()		#获取所有客户	
				map<i32, Customer> GetMap()		#获取所有客户	
			} 
		