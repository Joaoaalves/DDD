# Domain Events

Domain events represent **something meaningful that happened in the domain**.

They are:

* Raised inside entities or aggregates
* Stored internally until dispatched
* Pure domain constructs

Joaoaalves.DDD does not dispatch events.
It only models them.
