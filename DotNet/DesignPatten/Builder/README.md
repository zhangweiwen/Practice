建造者模式
========

建造者模式的目的是使用几个类去new一个产品类,直接在客户端new就是输,这个需求跟工厂方法一样,都是属于创建模式

1.首先是一个普通的产品类,由Builder和Director类负责构建

2.建造者的抽象类,可以定义一堆属性对应产品类,也可以只有一个Build方法

还一定需要一个获取产品类实例的方法或者属性

3.具体建造者类,这里是重写定义的属性,或者像下面这样在Build方法实现对产品的构建
这里是真正完成构建的地方

4.指挥者类,应该根据用户的需要去指挥Builder类怎样完成构建