using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace UdemyCourse_DesignPatternsInCSharpAndDotNET.BehavioralDesignPatterns._21State.More
{
    public interface State
    {
        public void doAction(Context context);
    }

    public class StartState : State
    {

        public void doAction(Context context)
        {
            WriteLine("Player is in start state");
            context.setState(this);
        }

        public String toString()
        {
            return "Start State";
        }
    }

    public class StopState : State
    {

        public void doAction(Context context)
        {
            WriteLine("Player is in stop state");
            context.setState(this);
        }

        public String toString()
        {
            return "Stop State";
        }
    }

    public class Context
    {
        private State state;

        public Context()
        {
            state = null;
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public State getState()
        {
            return state;
        }
    }
    class StatePatternDemo
    {
        public static void main(String[] args)
        {
            Context context = new Context();

            StartState startState = new StartState();
            startState.doAction(context);

            WriteLine(context.getState().ToString());

            StopState stopState = new StopState();
            stopState.doAction(context);

            WriteLine(context.getState().ToString());
        }
    }
}
