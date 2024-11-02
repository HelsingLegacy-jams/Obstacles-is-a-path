using System;
using System.Collections.Generic;
using Code.Infrastructure.StateMachine.States;

namespace Code.Infrastructure.StateMachine
{
  public class GameStateMachine : IStatesBinder, IGameStateMachine
  {
    private readonly Dictionary<Type, IState> _states = new ();
    private readonly IStateFactory _stateFactory;
    private IState _activeState;

    public GameStateMachine(IStateFactory stateFactory) => 
      _stateFactory = stateFactory;

    public void BindStates()
    {
      _states.Add(typeof(BootstrapState), _stateFactory.Create<BootstrapState>(this));
      _states.Add(typeof(LoadLevelState), _stateFactory.Create<LoadLevelState>(this));
      _states.Add(typeof(GameLoopState), _stateFactory.Create<GameLoopState>());
    }

    public void Enter<TState>() where TState : IState
    {
      _activeState?.Exit();
      
      IState state = _states[typeof(TState)];
      _activeState = state;
      
      state.Enter();
    }
  }
}