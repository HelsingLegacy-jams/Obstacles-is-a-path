﻿using Code.Infrastructure.StateMachine.States;

namespace Code.Infrastructure.StateMachine
{
  public interface IGameStateMachine
  {
    void Enter<TState>() where TState : IState;
  }
}