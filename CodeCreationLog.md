```Log

The default interactive shell is now zsh.
To update your account to use zsh, please run `chsh -s /bin/zsh`.
For more details, please visit https://support.apple.com/kb/HT208050.
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet buil
Could not execute because the specified command or file was not found.
Possible reasons for this include:
  * You misspelled a built-in dotnet command.
  * You intended to execute a .NET program, but dotnet-buil does not exist.
  * You intended to run a global tool, but a dotnet-prefixed executable with this name could not be found on the PATH.
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet build
Microsoft (R) Build Engine version 16.9.0+57a23d249 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
/usr/local/share/dotnet/sdk/5.0.201/NuGet.targets(131,5): warning : Unable to find a project to restore! [/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/DiscountCalculator.sln]

Build succeeded.

/usr/local/share/dotnet/sdk/5.0.201/NuGet.targets(131,5): warning : Unable to find a project to restore! [/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/DiscountCalculator.sln]
    1 Warning(s)
    0 Error(s)

Time Elapsed 00:00:00.33
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet sln add StarWars/StarWars.csproj
Project `StarWars/StarWars.csproj` added to the solution.
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet new xunit -o StarWarsTest
The template "xUnit Test Project" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on StarWarsTest/StarWarsTest.csproj...
  Determining projects to restore...
  Restored /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/StarWarsTest.csproj (in 1.11 sec).
Restore succeeded.

RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git status
On branch main
Your branch is up to date with 'origin/main'.

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        DiscountCalculator.sln
        StarWars/
        StarWarsTest/

nothing added to commit but untracked files present (use "git add" to track)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git add -A
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git commit -m "Initial Commit"
[main 41a84b7] Initial Commit
 15 files changed, 6186 insertions(+)
 create mode 100644 DiscountCalculator.sln
 create mode 100644 StarWars/ShoppingCart.cs
 create mode 100644 StarWars/StarWars.csproj
 create mode 100644 StarWars/obj/StarWars.csproj.nuget.dgspec.json
 create mode 100644 StarWars/obj/StarWars.csproj.nuget.g.props
 create mode 100644 StarWars/obj/StarWars.csproj.nuget.g.targets
 create mode 100644 StarWars/obj/project.assets.json
 create mode 100644 StarWars/obj/project.nuget.cache
 create mode 100644 StarWarsTest/StarWarsTest.csproj
 create mode 100644 StarWarsTest/UnitTest1.cs
 create mode 100644 StarWarsTest/obj/StarWarsTest.csproj.nuget.dgspec.json
 create mode 100644 StarWarsTest/obj/StarWarsTest.csproj.nuget.g.props
 create mode 100644 StarWarsTest/obj/StarWarsTest.csproj.nuget.g.targets
 create mode 100644 StarWarsTest/obj/project.assets.json
 create mode 100644 StarWarsTest/obj/project.nuget.cache
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git push
Enumerating objects: 22, done.
Counting objects: 100% (22/22), done.
Delta compression using up to 4 threads
Compressing objects: 100% (21/21), done.
Writing objects: 100% (21/21), 28.51 KiB | 788.00 KiB/s, done.
Total 21 (delta 6), reused 0 (delta 0)
remote: Resolving deltas: 100% (6/6), done.
To https://github.com/ramakrishnagithub/DiscountCalculator.git
   b57c30a..41a84b7  main -> main
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet sln add StarWarsTest/StarWarsTest.Proj
Could not find project or directory `StarWarsTest/StarWarsTest.Proj`.
Usage: dotnet sln <SLN_FILE> add [options] <PROJECT_PATH>

Arguments:
  <SLN_FILE>       The solution file to operate on. If not specified, the command will search the current directory for one.
  <PROJECT_PATH>   The paths to the projects to add to the solution.

Options:
  --in-root               Place project in root of the solution, rather than creating a solution folder.
  -s, --solution-folder   The destination solution folder path to add the projects to.
  -h, --help              Show command line help.
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ ls
DiscountCalculator.sln  README.md               StarWars                StarWarsTest
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet sln add StarWarsTest/StarWarsTest.csproj
Project `StarWarsTest/StarWarsTest.csproj` added to the solution.
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet add StarWarsTest/StarWarsTest.csproj reference StarWars/StarWars.csproj
Reference `..\StarWars\StarWars.csproj` added to the project.
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ ls
DiscountCalculator.sln  README.md               StarWars                StarWarsTest
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/SatrWarsTest.csproj
MSBUILD : error MSB1009: Project file does not exist.
Switch: StarWarsTest/SatrWarsTest.csproj
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  Restored /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/StarWarsTest.csproj (in 434 ms).
  1 of 2 projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:01.16]     StarWarsTest.UnitTest1.ZeroMoviesInShoppingCart [FAIL]
  Failed StarWarsTest.UnitTest1.ZeroMoviesInShoppingCart [4 ms]
  Error Message:
   System.NotImplementedException : The method or operation is not implemented.
  Stack Trace:
     at StarWars.ShoppingCart.ComputePrice() in /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/ShoppingCart.cs:line 13
   at StarWarsTest.UnitTest1.ZeroMoviesInShoppingCart() in /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/UnitTest1.cs:line 13

Failed!  - Failed:     1, Passed:     0, Skipped:     0, Total:     1, Duration: 4 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: 4 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:00.58]     StarWarsTest.UnitTest1.OneMovieInTheCartDoNotApplyDiscount [FAIL]
  Failed StarWarsTest.UnitTest1.OneMovieInTheCartDoNotApplyDiscount [< 1 ms]
  Error Message:
   System.NotImplementedException : The method or operation is not implemented.
  Stack Trace:
     at StarWars.ShoppingCart.AddMovie(String name) in /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/ShoppingCart.cs:line 14
   at StarWarsTest.UnitTest1.OneMovieInTheCartDoNotApplyDiscount() in /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/UnitTest1.cs:line 20

Failed!  - Failed:     1, Passed:     1, Skipped:     0, Total:     2, Duration: 5 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/ShoppingCart.cs(27,24): error CS0266: Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?) [/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/StarWars.csproj]
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     2, Skipped:     0, Total:     2, Duration: 4 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:00.61]     StarWarsTest.UnitTest1.TwoMovieInCartApplyFivePercentDiscount [FAIL]
  Failed StarWarsTest.UnitTest1.TwoMovieInCartApplyFivePercentDiscount [2 ms]
  Error Message:
   Assert.Equal() Failure
Expected: 19
Actual:   20
  Stack Trace:
     at StarWarsTest.UnitTest1.TwoMovieInCartApplyFivePercentDiscount() in /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/UnitTest1.cs:line 32

Failed!  - Failed:     1, Passed:     2, Skipped:     0, Total:     3, Duration: 7 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git commit -A -m "added Zero,OneMovie Test case and implementation"
error: unknown switch `A'
usage: git commit [<options>] [--] <pathspec>...

    -q, --quiet           suppress summary after successful commit
    -v, --verbose         show diff in commit message template

Commit message options
    -F, --file <file>     read message from file
    --author <author>     override author for commit
    --date <date>         override date for commit
    -m, --message <message>
                          commit message
    -c, --reedit-message <commit>
                          reuse and edit message from specified commit
    -C, --reuse-message <commit>
                          reuse message from specified commit
    --fixup <commit>      use autosquash formatted message to fixup specified commit
    --squash <commit>     use autosquash formatted message to squash specified commit
    --reset-author        the commit is authored by me now (used with -C/-c/--amend)
    -s, --signoff         add Signed-off-by:
    -t, --template <file>
                          use specified template file
    -e, --edit            force edit of commit
    --cleanup <mode>      how to strip spaces and #comments from message
    --status              include status in commit message template
    -S, --gpg-sign[=<key-id>]
                          GPG sign commit

Commit contents options
    -a, --all             commit all changed files
    -i, --include         add specified files to index for commit
    --interactive         interactively add files
    -p, --patch           interactively add changes
    -o, --only            commit only specified files
    -n, --no-verify       bypass pre-commit and commit-msg hooks
    --dry-run             show what would be committed
    --short               show status concisely
    --branch              show branch information
    --ahead-behind        compute full ahead/behind values
    --porcelain           machine-readable output
    --long                show status in long format (default)
    -z, --null            terminate entries with NUL
    --amend               amend previous commit
    --no-post-rewrite     bypass post-rewrite hook
    -u, --untracked-files[=<mode>]
                          show untracked files, optional modes: all, normal, no. (Default: all)

RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git commit -a -m "added Zero,OneMovie Test case and implementation"
[main b3a336e] added Zero,OneMovie Test case and implementation
 7 files changed, 133 insertions(+), 8 deletions(-)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git push
Enumerating objects: 23, done.
Counting objects: 100% (23/23), done.
Delta compression using up to 4 threads
Compressing objects: 100% (12/12), done.
Writing objects: 100% (12/12), 2.12 KiB | 197.00 KiB/s, done.
Total 12 (delta 6), reused 0 (delta 0)
remote: Resolving deltas: 100% (6/6), completed with 6 local objects.
To https://github.com/ramakrishnagithub/DiscountCalculator.git
   41a84b7..b3a336e  main -> main
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/ShoppingCart.cs(7,18): error CS1106: Extension method must be defined in a non-generic static class [/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/StarWars.csproj]
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/ShoppingCart.cs(31,23): error CS0103: The name 'ChunkBy' does not exist in the current context [/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/StarWars.csproj]
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:00.64]     StarWarsTest.UnitTest1.TwoMovieInCartApplyFivePercentDiscount [FAIL]
  Failed StarWarsTest.UnitTest1.TwoMovieInCartApplyFivePercentDiscount [7 ms]
  Error Message:
   Assert.Equal() Failure
Expected: 19
Actual:   20
  Stack Trace:
     at StarWarsTest.UnitTest1.TwoMovieInCartApplyFivePercentDiscount() in /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/UnitTest1.cs:line 32

Failed!  - Failed:     1, Passed:     2, Skipped:     0, Total:     3, Duration: 17 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:00.67]     StarWarsTest.UnitTest1.TwoMovieInCartApplyFivePercentDiscount [FAIL]
  Failed StarWarsTest.UnitTest1.TwoMovieInCartApplyFivePercentDiscount [6 ms]
  Error Message:
   Assert.Equal() Failure
Expected: 19
Actual:   20
  Stack Trace:
     at StarWarsTest.UnitTest1.TwoMovieInCartApplyFivePercentDiscount() in /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/UnitTest1.cs:line 32

Failed!  - Failed:     1, Passed:     2, Skipped:     0, Total:     3, Duration: 16 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     3, Skipped:     0, Total:     3, Duration: 15 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:00.60]     StarWarsTest.UnitTest1.TwoMovieInCartDoNotApplyFivePercentDiscount [FAIL]
  Failed StarWarsTest.UnitTest1.TwoMovieInCartDoNotApplyFivePercentDiscount [6 ms]
  Error Message:
   Assert.Equal() Failure
Expected: 19
Actual:   20
  Stack Trace:
     at StarWarsTest.UnitTest1.TwoMovieInCartDoNotApplyFivePercentDiscount() in /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/UnitTest1.cs:line 42

Failed!  - Failed:     1, Passed:     3, Skipped:     0, Total:     4, Duration: 16 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     4, Skipped:     0, Total:     4, Duration: 15 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:00.63]     StarWarsTest.UnitTest1.ThreeMoviesInCartApplyTenPercentDiscount [FAIL]
  Failed StarWarsTest.UnitTest1.ThreeMoviesInCartApplyTenPercentDiscount [4 ms]
  Error Message:
   Assert.Equal() Failure
Expected: 27
Actual:   29
  Stack Trace:
     at StarWarsTest.UnitTest1.ThreeMoviesInCartApplyTenPercentDiscount() in /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/UnitTest1.cs:line 53

Failed!  - Failed:     1, Passed:     4, Skipped:     0, Total:     5, Duration: 18 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:00.61]     StarWarsTest.UnitTest1.ThreeMoviesInCartApplyTenPercentDiscount [FAIL]
  Failed StarWarsTest.UnitTest1.ThreeMoviesInCartApplyTenPercentDiscount [3 ms]
  Error Message:
   Assert.Equal() Failure
Expected: 27
Actual:   29
  Stack Trace:
     at StarWarsTest.UnitTest1.ThreeMoviesInCartApplyTenPercentDiscount() in /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/UnitTest1.cs:line 53

Failed!  - Failed:     1, Passed:     4, Skipped:     0, Total:     5, Duration: 17 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     5, Skipped:     0, Total:     5, Duration: 14 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     6, Skipped:     0, Total:     6, Duration: 14 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git commit -a -m "added test cases and logic for three movie Discount"
[main b28e376] added test cases and logic for three movie Discount
 2 files changed, 79 insertions(+), 2 deletions(-)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git push
Enumerating objects: 11, done.
Counting objects: 100% (11/11), done.
Delta compression using up to 4 threads
Compressing objects: 100% (6/6), done.
Writing objects: 100% (6/6), 1.59 KiB | 272.00 KiB/s, done.
Total 6 (delta 0), reused 0 (delta 0)
To https://github.com/ramakrishnagithub/DiscountCalculator.git
   b3a336e..b28e376  main -> main
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git status
On branch main
Your branch is up to date with 'origin/main'.

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        StarWars/bin/
        StarWars/obj/Debug/
        StarWarsTest/bin/
        StarWarsTest/obj/Debug/

nothing added to commit but untracked files present (use "git add" to track)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     6, Skipped:     0, Total:     6, Duration: 17 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/ShoppingCart.cs(22,13): error CS0131: The left-hand side of an assignment must be a variable, property or indexer [/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/StarWars.csproj]
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/ShoppingCart.cs(22,13): error CS0131: The left-hand side of an assignment must be a variable, property or indexer [/Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/StarWars.csproj]
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     6, Skipped:     0, Total:     6, Duration: 22 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git commit -a -m "added logic for dynamic chunkSizeCalculation"
[main dacb324] added logic for dynamic chunkSizeCalculation
 1 file changed, 4 insertions(+), 3 deletions(-)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git push
Enumerating objects: 7, done.
Counting objects: 100% (7/7), done.
Delta compression using up to 4 threads
Compressing objects: 100% (4/4), done.
Writing objects: 100% (4/4), 500 bytes | 500.00 KiB/s, done.
Total 4 (delta 2), reused 0 (delta 0)
remote: Resolving deltas: 100% (2/2), completed with 2 local objects.
To https://github.com/ramakrishnagithub/DiscountCalculator.git
   b28e376..dacb324  main -> main
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     6, Skipped:     0, Total:     6, Duration: 19 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:00.63]     StarWarsTest.UnitTest1.FourMoviesInCartApplyTwentyPercentDiscount [FAIL]
  Failed StarWarsTest.UnitTest1.FourMoviesInCartApplyTwentyPercentDiscount [2 ms]
  Error Message:
   Assert.Equal() Failure
Expected: 32
Actual:   37
  Stack Trace:
     at StarWarsTest.UnitTest1.FourMoviesInCartApplyTwentyPercentDiscount() in /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/UnitTest1.cs:line 76

Failed!  - Failed:     1, Passed:     6, Skipped:     0, Total:     7, Duration: 22 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     7, Skipped:     0, Total:     7, Duration: 20 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     8, Skipped:     0, Total:     8, Duration: 22 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ dotnet test StarWarsTest/StarWarsTest.csproj
  Determining projects to restore...
  All projects are up-to-date for restore.
  StarWars -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWars/bin/Debug/net5.0/StarWars.dll
  StarWarsTest -> /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll
Test run for /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     9, Skipped:     0, Total:     9, Duration: 23 ms - /Users/ramakrishnachodisetti/GitPersonal/DiscountCalculator/StarWarsTest/bin/Debug/net5.0/StarWarsTest.dll (net5.0)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git commit -a -m "added six movies test case"
[main caa698c] added six movies test case
 2 files changed, 40 insertions(+), 2 deletions(-)
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ git push
Enumerating objects: 11, done.
Counting objects: 100% (11/11), done.
Delta compression using up to 4 threads
Compressing objects: 100% (6/6), done.
Writing objects: 100% (6/6), 824 bytes | 412.00 KiB/s, done.
Total 6 (delta 2), reused 0 (delta 0)
remote: Resolving deltas: 100% (2/2), completed with 2 local objects.
To https://github.com/ramakrishnagithub/DiscountCalculator.git
   dacb324..caa698c  main -> main
RAMAKRIHNAsMini:DiscountCalculator ramakrishnachodisetti$ 