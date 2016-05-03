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