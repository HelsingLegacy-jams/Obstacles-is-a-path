﻿using Code.Infrastructure.StateMachine.States;

namespace Code.Infrastructure.Factory
{
  public interface IStateFactory
  {
    T Create<T>() where T : IState;
    T Create<T>(params object[] args) where T : IState;
  }
}