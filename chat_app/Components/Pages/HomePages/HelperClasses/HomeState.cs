namespace chat_app.Components.Pages.HomePages.HelperClasses
{


    public class HomeState
    {
        public enum State
        {
            Home,
            Login,
            Register
        }

        public State CurrentState { get; set; } = State.Home;
        public State NextState { get; set; }
        public string Container { get; set; } = "fade-in-card";


        public bool IsHome()
        {
            return CurrentState == State.Home;
        }

        public bool IsLogin()
        {
            return CurrentState == State.Login;
        }

        public bool IsRegister()
        {
            return CurrentState == State.Register;
        }


        public void SetLogin()
        {
            Container = "fade-out-card";
            NextState = State.Login;


        }

        public void SetRegister()
        {
            Container = "fade-out-card";
            NextState = State.Register;

        }

        public void ChangeState()
        {
            CurrentState = NextState;
            Container = "fade-in-card";

        }




    }
}
