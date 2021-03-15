# Sheng.Mapper

请访问原版代码库，以获得最新更新: https://github.com/iccb1013/Sheng.Mapper

MIT 协议开源，可以随意使用，但是需在源代码和产品关于画面保留版权声明和我的网站链接，谢谢。

对象属性值映射/拷贝工具。不需要创建映射规则，不要求对象类型一致，适用于简单直接的拷贝操作，可以全属性拷贝，指定属性拷贝，排除指定的属性。拷贝包含 10 个属性的对象 10 万次，耗时 4.x 秒（普通开发机）。

+ 拷贝行为只针对 sourceObject 和 targetObject 所共有的属性
+ 在 sourceObject 和 targetObject 中的待拷贝的属性值的类型处理：如果是值类型，直接拷贝，如果是引用类型，sourceObject 中的属性的类型 必须 和 targetObject 中的属性的类型一致，或是它的派生类
+ 如果要支持类型不一致的属性自动进行类型转换，你可以在 PropertyMappingDescription 这个类中实现转换器功能
+ 拷贝行为 不会 改变 targetObject 中不需要被拷贝的属性的值
+ 你可以组合使用几个方法来从多个对象中拷贝指定的属性值到一个 targetObject

和 AutoMapper 互补，与之相比最大优势是短，平，快。不需要创建复杂的映射规则，并支持属性排除操作。

详细说明：
https://blog.shengxunwei.com/Home/Post/bde984a5-5c13-4667-ae8e-0e1a31e6bc2a

详细说明请浏览：
https://shengxunwei.com

曹旭升（sheng.c）  
QQ:279060597  
Email：cao.silhouette@msn.com  
@南京 


