# Sheng.Mapper

对象属性值映射/拷贝工具。不需要创建映射规则，不要求对象类型一致，适用于简单直接的拷贝操作，可以全属性拷贝，指定属性拷贝，排除指定的属性。拷贝包含 10 个属性的对象 10 万次，耗时 4.x 秒（普通开发机）。

+ 拷贝行为只针对 sourceObject 和 targetObject 所共有的属性
+ 在 sourceObject 和 targetObject 中的待拷贝的属性值的类型处理：如果是值类型，直接拷贝，如果是引用类型，sourceObject 中的属性的类型 必须 和 targetObject 中的属性的类型一致，或是它的派生类
+ 如果要支持类型不一致的属性自动进行类型转换，你可以在 PropertyMappingDescription 这个类中实现转换器功能
+ 拷贝行为 不会 改变 targetObject 中不需要被拷贝的属性的值
+ 你可以组合使用几个方法来从多个对象中拷贝指定的属性值到一个 targetObject
