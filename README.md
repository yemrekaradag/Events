# Events

Events
• An event is a notification sent by an object to notify that an action has occurred.
• The class that generates the event is called Publisher, and the class that receives the notification is called Subscriber. A single event can have multiple subscribers.
• Typically, a broadcaster fires an event when an action occurs. Subscribers who want to be notified when an action occurs must register for an event and take the corresponding actions.
• An event in C# is an encapsulated delegate. Depends on the agent. The delegate defines the signature of the event handler method of the subscriber class.

In this example, we want the user to enter a number. If a character is entered, the program stops.

Steps in event design
1. Declare a delegate.
2. Declare a variable of the delegate using the event keyword.
3. Create an event-raising method in the Publisher class.
4. Create a method (event handler) that performs the actions to be taken when an event occurs in the subscriber class.


<img alt="events1" src="https://user-images.githubusercontent.com/107070882/205653726-27dd2334-a770-41ac-975d-267eba902fb8.png">

<img alt="events2" src="https://user-images.githubusercontent.com/107070882/205654474-6fff6a08-0991-48cf-8736-677cb80e26e3.png">

<hr>

Olaylar (Events)
• Olay (event), bir eylemin meydana geldiğini bildirmek için bir nesne tarafından gönderilen bir bildirimdir.
• Olayı oluşturan sınıfa Yayıncı (Publisher), bildirimi alan sınıfa Abone (Subscriber) adı verilir. Tek bir olayın birden fazla abonesi olabilir.
• Tipik olarak, bir yayıncı, bir eylem gerçekleştiğinde bir olayı başlatır. Bir eylem gerçekleştiğinde bildirim almak isteyen aboneler, bir olaya kaydolmalı ve onu karşılık gelen aksiyonları yerine getirmelidirler.
• C#'ta bir olay, kapsüllenmiş bir temsilcidir. Temsilciye bağlıdır. Temsilci, abone sınıfın olay işleyici yönteminin imzasını tanımlar.

Bu örnekte kullanıcıdan sayı girmesini istiyoruz eğer tek sayı girerse olay tetikleniyor, çift girerse kullanıcıdan tekrar sayı girmesini istiyoruz. Eğer karakter girerse program duruyor.

Olay tasarımındaki adımlar
1. Bir delege deklare et.
2. event anahtar kelimesi kullanarak delegenin bir değişkenini deklare et.
3. Yayıncı sınıfta bir olay oluşturucu yöntem oluştur.
4. Abone sınıfta olay oluştuğunda yapılacak aksiyonları yerine getiren bir yöntem oluştur (event handler).

<img alt="events1" src="https://user-images.githubusercontent.com/107070882/205653726-27dd2334-a770-41ac-975d-267eba902fb8.png">

<img alt="events2" src="https://user-images.githubusercontent.com/107070882/205654474-6fff6a08-0991-48cf-8736-677cb80e26e3.png">

