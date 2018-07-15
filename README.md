﻿# 什么是设计模式？
 一般来讲，设计模式提供了一种解决具体问题的方案。
 # 为什么要学习设计模式？
>**没有学习过设计模式，那么对于多态、乃至面向对象的理解多半是肤浅和片面的。** 相信也有那种可以听一知十，但是大多数程序员还是需要踏踏实实地学习基本的东西，并在不断地实践中成长，最终成为高手。只有把设计模式理解好了，才能算是真正的懂得面向对象编程。
# 面向对象基础
## 什么是对象？
>一切事物皆对象，即所有的东西都是对象，对象可以使看得到、察觉到、听到、触摸到、尝到、闻到的东西。准确的讲**对象是一个自包含的实体，用一组可识别的特性和行为来标识。**
## 什么是类？
>类是具有相同的属性和功能的对象的集合
## 什么是实例？
>**实例就是一个真实的对象**。比如说我们都是“人”，而你和我其实就是“人”类的实例。**实例化就是创建对象的过程，使用new关键字来创建。**
## 抽象类和接口
>**类是对对象的抽象，抽象类是对类的抽象，接口是对行为的抽象。**接口是对类绝不行为进行抽象，抽象类是对类整体进行抽象，都是在不同的层次、不同角度进行抽象的结果，他们的共性就是抽象。**实现接口和继承抽象类并不冲突**，我么完全可以让超人继承人类，在实现飞行接口。从设计的角度讲，抽象类更像是从子类中发现了公共的东西，泛华出父类，然后子类继承父类；而接口根本不知道子类的存在，方法如何实现还不确定，预先定义。
# 概述
>编程是一门技术，更是一门艺术，不能只满足写完代码运行结果正确就完事，时常考虑让代码更加精炼，容易维护，容易扩展和复用，只有这样才能够得到真正的提高代码的灵活性。
>**通过封装、继承、多态减低程序耦合性，全面提升代码的可维护性(修改)、可复用性、可扩展性(新增)、灵活性。**
>1.面向对象的编程并不是类越多越好，类的划分是为了封装，分类的基础是抽象，具有相同属性和功能的对象的抽象集合才是类
>2.封装变化点是面向对象一种很重要的思维方式。
>3.通过重构改善既有代码的设计。
>4.面向对象设计其实就是希望做到代码的责任分离
# 客套
>**学无止境，只有不断地学习和实践才能真正成为优秀的软件工程师，研究历史是为了更好的迎接未来**。隔行如隔山，任何行业都有技巧和经验，需要多思考、多琢磨，才能做到最好。**编程又何尝不是这样，代码没有最好，只有更好，需要不断努力**。只要真正深入地理解了设计原则，很多设计模式其实都是原则的实际运用而已，或许在不知不觉中就在使用设计模式。
# 总结
>根据设计模式的特点可以分为创建型模式、结构型模式、行为型模式。
## 创建型模式
1. **抽象工厂(Abstract Factory)**: 提供一个创建一系列或相关对象的接口，而不需指定它们具体的类。
2. **建造者(Builder)**: 将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
3. **工厂方法(Factory Method)**: 通俗易懂地讲就是在某个类型中定义创建依赖对象的方法。这个类型可以是接口、抽象类、未被封闭的具体类型(Sealed)。如果类型是接口和抽象类，那么子类根据业务需要自己决定重写那些方法，每增加一种产品只需多增加一个工厂实现类就可以了，使用的时候在决定具体实例化哪一个类。
>- 优点
1. 将内部实例化对象的逻辑转移到客户端代码中来进行。
2. 使一个类的实例化延迟到了子类。
>- 缺点
   随着业务流程的变化，每增加一个产品就需要增加一个工厂类。
4. **原型(Prototype)**: 用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。
5. **单例(Singleton)**: 保证一个类只有一个实例，并提供一个访问它的全局访问点。
>### 为什么需要创建型模式?
>创建型模式隐藏了这些类的实例是如何被创建和放在一起的，整个系统关于这些对象所知道的是由抽象类定义的接口。这样，创建型模式在创建了什么、谁创建它、它是肿么被创建的、以及何时创建这方面提供了很大的灵活性。当一个系统应该独立于它的产品创建、构成和表示时，应该使用创建者模式。建立相应的模型并克隆它们通常比每次用合适的状态手工实例化该类更方便一下。**内聚性描述的是一个例程内部组成部分之间相互联系的紧密程度。而耦合性描述的是一个例程与其它例程之间联系的紧密程度。内部完整也就是高内聚，而与其它例程之间的联系是小巧、直接、可见、灵活的，这就是松耦合**。将一个复杂对象的构建与它的表示分离，这就可以很容易地改变一个产品的内部表示，并且使得构建代码和表示代码分开。这样对于客户端而言，它无需关系产品的创建过程，而只要告诉我需要什么，我就能用同样的构建过程创建不同的产品给客户。对于一些类来说，一个实例很重要。
## 结构型模式
>1. **适配器(Adapter)**: 将一个类的接口装换成客户希望的另外一个接口。适配器模式使得原本由于接口不兼容而不能一起工作的类可以一起工作。
>2. **桥接(Bridge)**: 将抽象部分与实现部分分离，使它们可以独立地变化。
>3. **组合(Composite)**: 将对象组合成树形结构表示“部分-整体”的层次结构，组合模式使得用户对单个对象和组合对象的使用具有一致性。
>4. **装饰(Decrator)**: 动态地给一个对象添加一些额外的职责。就增加功能而言，装饰模式相比生产子类更加灵活。
>5. **外观(Facade)**: 为子系统中的一组接口提供一个一致的界面，外观模式定义了一个高层接口，这个接口使得子系统更加容易使用。
>6. **享元(Flyweight)**: 运用共享技术有效地支持大量细粒度的对象。
>7. **代理(Proxy)**: 为其他对象提供一种代理一控制对这个对象的访问。
>### 适配器模式---开放闭合原则
>面向对象的精神就是更好地应对需求的变化，而现实中往往会有下面一些情况，想使用一个已经存在的类，而它的接口不符合要求，或者希望创建一个可以复用的类，该类可以与其它不相关的类或不可预见的类协同工作。正如开放闭合倡导的对修改关闭，对扩展开放的原则，所以让这些接口不同的类通过适配器进行工作。
>**问题发生之后进行适配处理，适配的是对象**
>### 桥接模式--合成聚合复用原则
>继承是个好东西，但往往会过度地使用，继承会导致类的结构过于复杂，关系太多，难以维护，更糟糕地是扩展性非常差。而仔细观察如果发现继承体系中，有两个甚至多个方向的变化，那么就**解耦这些不同方向上的变化，通过对象组合的方式，把两个角色之间的继承关系改为组合的关系，从而使这两者可以独立的变化**。事实上合成聚合复用原则，主张的就是找出变化封装之。
>**在设计之初就想好如何应对变化，通过将抽象接口与它的实现部分分离，让抽象与实现可以独立演化**
>### 装饰模式--合成聚合复用原则
>面对变化如果采用生成子类的方法进行扩充，为支持每一种扩展的组合，会产生大量的子类，使得子类数目程爆炸性增长。而事实上，这些子类多半只是为某个对象增加一些职责，此时通过装饰的方式，可以更加灵活、**以动态、透明的方式给单个对象添加职责**，并在不需要时，撤销相应的职责。
>**为现存系统提供一个更为方便的接口，适配的是整个系统**
>### 组合模式--里式替换原则
>用户可以忽略组合对象和单个对象的不同，用户将可以统一地使用组合结构中的所有对对象。用户使用组合接口与组合结构中的对象进行交互，如果接受者是一个叶节点，则直接处理请求，如果接受者是一个枝节点，通常将请求发给它的子部件，并在转发之前或之后执行一些复杂操作。组合模式的效果是**客户可以一致地使用组合结构和单个对象。任何用到基本对象的地方都可以使用组合对象**。
>### 外观模式--迪米特原则
>**信息的隐藏促进软件的复用**。类之间的耦合越弱，越有利于复用，一个处在弱耦合的类修改，不会对有关系的类造成波及。如果两个不必彼此直接通信，那么就不要让这两个类发生直接的作用。如果实在需要调用，可以使用第三方来进行转发。为了让一个软件中子系统的通信方式和相互依赖的关系达到最小，而具体的办法就是引入一个外观对象，它为子系统间提供一个单一而简单的屏障。通常企业软件分为三层或N层架构，层与层之间地分离其实就是外观模式的体现。
>### 享元模式--单一职责原则
>**对象使得内存占用过多，而且如果都是大量重复的细粒度对象，那就是资源的极大浪费**，会使得机器性能减慢。面向对象的技术有时会因为简单化的设计而代价极大。
>### 代理模式--迪米特原则
>**代理与外观主要的区别在于，代理对象代表一个单一对象，而外观对象代表一个子系统。代理的客户对象无法直接访问目标对象，由代理提供对单独目标对象的访问控制，而外观的客户对象可以访问子系统中的各个对象，但通常由外观对象提供对子系统各元件功能的简化的共同层次的调用接口**。代理模式与适配器模式都是属于一种衔接性质的功能。**代理是原来对象的一种代表，其他需要和这个对象打交道的操作都是和这个代表交涉，而适配器者不需要虚拟出一个代表者，只需要为应对特定目的，将原来的类进行组合**。
## 行为模式一组
>1. **观察者(Observer)**: 定义对象间的一种一对多的依赖关系，当一个对象的状态发生改变时，所有依赖它的对象都得到通知并自动更新。
>2. **模板方法(Template Method)**: 定义一个操作的相关算法骨架，而将一些步骤延迟到子类中，使得子类可以不改变一个算法的结构既可以重新定义该算法的某些特定步骤。
>4. **命令(Command)**: 将一个请求封装成一个对象，从而使你可用不同的请求对客户进行参数化；可以对请求排队或记录请求日志，以及撤销操作。
>5. **状态(State)**: 允许一个对象内部状态改变时改变它的行为，让对象看起来似乎修改了它的类。
>6. **职责链(Chain Of Responsibility)**: 使用多个对象都有机会处理请求，从而避免请求的发送者和接受者之间的耦合。将这些对象连成一条链，并延着这条链传递该请求，知道有一个对象处理它为止。
>### 命令模式--单一职责原则
>**将调用操作的对象与知道如何实现该操作的对象解耦**，比如完全可以在实施操作前就将状态存储起来，以便支持取消/撤销操作。还可以记录整个操作日志，以便日后再系统出问题时查找原因或恢复重做。当然也可以支持事务，要么所有的命令都成功，要么恢复到没有执行的状态。总之，如果有类似的需时，利用命令模式分离请求者或实现者，是最明智的选择。
>### 职责链模式--单一职责原则
>**有多个对象可以处理一个请求，有哪个对象处理请求事先并不知道，要在运行时刻自动确定，此时，最好的办法就是让请求者与具体处理者分离，让客户在不明确指定接受者的情况下，提交一个请求，然后由所有能处理者请求的对象连成一条链，并延着这条链传递请求，直到有一个对象处理它为止**。
>### 状态模式--开放闭合原则
>**状态模式提供了一个更好的方法来组织与特定状态相关的代码，决定状态转移的逻辑不在单个的If和Switch中，而是分布在各个状态子类之间，由于所有与状态相关的代码都存在于某个状态子类中，所有通过定义新的子类可以很容易地增加新的状态和转换**。
## 行为模式二组
>1. **解释器(Interpreter)**: 给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语言中的句子。
>2. **中介者(Mediator)**: 用一个中间对象来封装一系列的对象交互。中介者使得过对象不需要显示地引用，从而使其耦合松散，而且可以独立地改变它们之间的交互。
>3. **访问者(Visitor)**: 表示一个作用于某个对象结构中的各元素的操作。它使得你可以在不改变各元素的类的前提下定义作用于这些元素的新操作。
>4. **策略(Strategy)**: 定义一系列的算法，把它们一个个封装起来，并且使得它们可相互转换。本模式使得算法可以独立于它的客户而变化。
>5. **备忘录(Memento)**: 在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样以后就可以将该对象恢复到原先保存的状态了。
>6. **迭代器(Iterator)**: 提供一种方法顺序的访问聚合中各个元素，而又不暴露该对象的内部表示。
>### 解释器模式--依赖倒置原则
>再编程的世界里，实现目标都是通过编写语言并执行实现的，从最低级的机器语言到人能很容易读懂机器也可以执行的高级语言，但是高级语言编写一些问题肯能还是比较复杂。**如果一种特定类型的问题发生的频率足够高，那么就可以考虑将该问题的各个实例表述为一个简单语言中的句子。也就是说通过一个解释器，该解释器通过解释这些句子来解决问题**。比如正则表达式就是一种描述字符串模式的一种标准语言。
>### 中介者模式--迪米特原则
>面向对象设计鼓励将行为封装到对象中，这种分布可能会导致对象间有很多连接。也就是说，有可能每个对象都需要知道其他许多对象。对象间的大量相互连接使得一个对象似乎不太可能在没有其他对象的支持下工作，这对于应对变化时不利的，任何较大的改动都很困难。将集体行为封装一个单独的中介者对象来避免这个问题，中介者复杂控制和协调一组对象间的交互。中介者充当一个中介可以使组中的对象不再相互显示引用。这些对象只知道中介者，从而减少相互连接的数目。这也是迪米特原则倡导的最少知识原则，也就是减少耦合的问题，类之间耦合越弱，越利于复用。
>### 访问者模式--合成聚合复用原则
>访问者增加具体的Element是困难的，但增加依赖与复杂对象结构的操作就容易。仅需增加一个新的访问者即可。
>### 策略模式--合成聚合复用原则
>继承提供了一种支持多种算法或行为的方法，我们可以直接生产一个类A的子类B、C、D，从而给它们不同行为。但这样会将行为硬编制到父类A中，而将算法的实现与类A的实现混合起来，从而使得A难以理解、难以维护、难以扩展，而且还不能动态地改变算法。仔细分析会发现，它们之间的唯一差别是它们所使用的算法或行为，将算法封装在独立的策略类中使得你可以独立与A类改变它，使它易于切换、易于理解、易于扩展。这里显然使用对象组合要优于继承。
>### 备忘录模式--单一职责原则
>通常原对象A都有很多状态属性，保存对象的内部状态，其实这些状态属性的值可以记录到A对象之外的两一个对象B，但是如果记录过程对外透明，那就意味着保存过程耦合了对象状态细节，它可以避免一些只因有A管理但有必须存储在A之外的信息。备忘录模式把可能很复杂的对象A的内部信息对其他对象屏蔽起来了，从而保持封装边界。
>### 迭代器模式
>一个集合对象，它当中具体是些什么对象元素我不知道，但不管如何，应该提供一种方法让别人来访问它的元素，而且可能一不同的方式遍历这个集合。**迭代器模式的关键思想是将列表的访问和遍历从列表对象中分离出来并放入到一个迭代器对象中，迭代器类定义一个访问该列表元素的接口。迭代器复杂跟踪当前的元素，并且知道哪些元素已经遍历过了**。
