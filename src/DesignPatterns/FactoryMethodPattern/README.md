﻿# 定义
  定义一个创建对象的接口，让子类决定实例化哪一个类。
# 示例场景
  实现计算器
# 总结
1. 简单工厂模式的最大优点在于工厂类中包含了必要的逻辑判断，根据客户端的选择动态实例化类，对呀客户端来说，去除了产品的依赖。但是当我们需需要增加新功能时，就要修改工厂里面的逻辑判断，这就等于说，不仅对扩展开放了，也对修改开放了，这样就违背[开放-闭合原则]，所以工厂方法就来了。
2. 工厂方法模式实现时，客户端需要决定去实例化哪一个工厂来实现运算类，选择判断的地方还是存在的，也就是说，工厂方法模式将简单工厂模式内部实例化对象的逻辑转移到客户端代码来进行。你想要增加功能，本来是改工厂的，现在是修改客户端。但是工厂方法客服了简单工厂违背开放-闭合原则的缺点，同时又保持了封装对象创建过程的优点。
3. 工厂方法模式集中封装了对象的创建，使得更换对象时，不需要大的改动就可实现，降低了客户端程序和产品对象的耦合。工厂方法模式是简单工厂模式的进一步抽象和推广。由于使用多态，工厂方法模式保持了简单工厂模式的优点，同时也克服了它的缺点。
# 缺点
  每增加一个产品，就需要增加一个额外的产品工厂类，增加了额外的开发量。
# 优点
  工厂方法使一个类的实例化延迟到了子类。