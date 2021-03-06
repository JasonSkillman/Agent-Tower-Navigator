﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObservable {

    void Register(IObserver observer);
    void Unregister(IObserver observer);
    void Notify();

}
