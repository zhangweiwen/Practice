装饰模式
========

所谓装饰模式能动态添加功能的说法是错误的,例如某例子说要为这个电话添加蓝牙和GPS功能.

其实根本没有添加功能,只不过是在执行方法的前后额外运行一些方法而已,类似AOP.

装饰是对方法进行装饰,类的功能永远只有2个.

> public abstract class AbstractCellPhone
> 
> {
> 
>     public abstract string CallNumber();
> 
>     public abstract string SendMessage();
> 
> }