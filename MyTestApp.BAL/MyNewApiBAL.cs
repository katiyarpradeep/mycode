using MyTestApp.IAL;
using System;
using static MyTestApp.DAL.MyCustomEntity;

namespace MyTestApp.BAL
{
    public class MyNewApiBAL : IMyNewAPI
    {
        public MyCustomResponse GetAllData()
        {
            MyCustomResponse response = new MyCustomResponse();
            try
            {
                response.status = true;
                response.response = "API called successfully";
            }
            catch (Exception ex)
            {
                response.status = false;
                response.response = "Exception occoured";
            }
            return response;
        }
    }
}
