using ObserverPattern;

var subject = new Subject();
var observerA = new Observer("A");
var observerB = new Observer("B");
subject.RegisterObserver(observerA);
subject.SetState(1);
subject.RegisterObserver(observerB);
subject.SetState(2);
subject.RemoveObserver(observerA);
subject.SetState(3);
