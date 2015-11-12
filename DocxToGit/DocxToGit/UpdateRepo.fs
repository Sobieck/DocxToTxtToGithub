module UpdateRepo
    
    open Octokit

    let run task =
        Async.AwaitTask(task) |> Async.RunSynchronously

    let github credentials = 
        
        let creds = new Credentials(credentials)

        let git = new GitHubClient(new ProductHeaderValue("DocxToTxtToGithub"), Credentials = creds);
        
        //let search = new SearchRepositoriesRequest("zoe")
        //
        //let gitSearch = git.Search.SearchRepo(search)
        //
        //let result = Async.AwaitTask(gitSearch) |> Async.RunSynchronously

        let result2 = git.Repository.GetAllForCurrent() |> Async.AwaitTask |> Async.RunSynchronously

        let another = git.Repository.Get("Sobieck00", "LisaBook") |> run

        0
