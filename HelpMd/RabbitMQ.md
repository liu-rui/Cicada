
### 这是有关消息队列类型项目的介绍，其中包括消息队列服务（Server）和消息队列客户端（Client）：
	一、消息队列服务端的介绍：
		* 1.1、消息队列服务端项目类型是一般处理程序；通过NuGet包引用下载的程序包括Cicada.Boot和Cicada.Mq，因为用的是一般处理程序，
			最后要打包成系统服务，所以也引用Cicada.Boot.Service。
		* 1.2、添加一个用来处理具体业务的逻辑类，我们命名为OrderCreateReceive，这个类继承IReceiver这个接口，其中IReceiver<T>的T是
			客户端要传送的数据类型，要是实现Receive这个方法，具体的业务处理都在这个方法里面进行。
		* 1.3、因为最终要部署成系统服务，所以要配置Service，通过配置Start和Stop方法，消息队列的服务也就启动或者停止了，具体如何配
			置，请查看示例项目。
		* 1.4、最后要配置的就是Cicada.properties。首先配置AutoRegisterByProductName；因为要打包成系统服务，Windows Service项要配置
			对应的信息；然后就是消息队列的接收方，具体如何配置请参看配置说明。
	
	
	二、消息队列客户端的介绍：
		* 2.1、消息队列的客户端示例用的也是一般处理程序，要引用的程序包包含Cicada.Boot和Cicada.Mq。
		* 2.2、调用要实现ISender的Send方法，第一个参数对应的是配置信息中的Channel，第二个要参数是要传输的参数。
		* 2.3、最后就是配置Cicada.properties。首先还是AutoRegisterByProductName；然后就是消息队列的发送方配置信息，根据配置说明
			填写对应信息。
		
		
	