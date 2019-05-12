# Chain of Responsibility Pattern 责任链模式
## Definition

Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.
<br>使多个对象都有机会处理请求，从而避免了请求的发送者和接受者之间的耦合关系。将这些对象连成一条链，并沿着这条链传递该请求，直到有对象处理它为止。

![](https://github.com/QianMo/Unity-Design-Pattern/blob/master/UML_Picture/chain.gif)


## Participants

The classes and objects participating in this pattern are:

### Handler   (Approver)
* defines an interface for handling the requests
* (optional) implements the successor link

### ConcreteHandler   (Director, VicePresident, President)
* handles requests it is responsible for
* can access its successor
* if the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor

### Client   (ChainApp)
* initiates the request to a ConcreteHandler object on the chain


//Su dung nhu cac mat xich,neu ma khong phu hop voi mat xich nay thi se chuyen sang mat xich khac duoc dinh nghia thao tac 
//tac dung: chi can dung 1 thuc the,khong can quan tam den cac thang thuc the khac khi thuc thi
*Normal
{
if(A*) A
else if(B*) B}

*Pattern
class A'{if(A*) A else (change to B*)}
class B'{if(B*) B else (change to C*)}

//example




