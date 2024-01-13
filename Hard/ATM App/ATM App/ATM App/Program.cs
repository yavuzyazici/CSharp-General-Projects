using ATM_App;
using System;

Controller C =  new Controller();
Log log = new Log();

log.CheckAndCreate();

C.Start();