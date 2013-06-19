原型模式
========

就是一个可复制的类,在C#一个扩展方法即可,没必要实现原型模式

> public static class ExtensionMethods

> {

>     // Deep clone

>     public static T DeepClone<T>(this T a)

>     {

>         using (MemoryStream stream = new MemoryStream())

>         {

>             BinaryFormatter formatter = new BinaryFormatter();

>             formatter.Serialize(stream, a);

>             stream.Position = 0;

>             return (T) formatter.Deserialize(stream);

>         }

>     }

> }