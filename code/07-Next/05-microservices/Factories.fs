module Finance.Factories

module Repositories =
    module Account =
        open Finance.Account.Repository

        let Memory = 
            {
                Get = Memory.get
                Put = Memory.put
            } 

        let File = 
            {
                Get = File.get
                Put = File.put
            } 
