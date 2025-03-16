# Sheng.Mapper

cao.silhouette@msn.com

Please visit the original code repository for the latest updates: https://github.com/iccb1013/Sheng.Mapper

Object property value mapping/copy tool. It does not require creating mapping rules and does not require object types to be identical, making it suitable for simple and direct copy operations. It allows for copying all properties, specifying properties to copy, or excluding specific properties.

The copy behavior only applies to properties that are common to both the sourceObject and targetObject. For properties in the sourceObject and targetObject that are to be copied, the type handling is as follows: if it is a value type, it is copied directly. If it is a reference type, the property type in the sourceObject must match the property type in the targetObject, or be a derived class. If you need to support automatic type conversion for properties with inconsistent types, you can implement a converter function in the PropertyMappingDescription class. The copy behavior will NOT change the values of properties in the targetObject that are not to be copied. You can combine several methods to copy specified property values from multiple objects into a single targetObject. Complementary to AutoMapper, its biggest advantages over AutoMapper are simplicity, speed, and efficiency. It does not require creating complex mapping rules and supports property exclusion.
