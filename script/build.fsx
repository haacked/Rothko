#r @"..\tools\FAKE.Core\tools\FakeLib.dll"
open Fake 
open Fake.XUnit2Helper

let authors = ["Phil Haack"]

// project name and description
let projectName = "Rothko"
let projectDescription = "Abstractions!"
let projectSummary = projectDescription // TODO: write a summary

// directories
let buildDir = "./src/bin"
let testResultsDir = "./testresults"

RestorePackages()

let releaseNotes = 
    ReadFile ".\ReleaseNotes.md"
    |> ReleaseNotesHelper.parseReleaseNotes

Target "Clean" (fun _ ->
    CleanDirs [buildDir; testResultsDir]
)

open Fake.AssemblyInfoFile

Target "AssemblyInfo" (fun _ ->
    CreateCSharpAssemblyInfo ".\SolutionInfo.cs"
      [ Attribute.Product projectName
        Attribute.Version releaseNotes.AssemblyVersion
        Attribute.FileVersion releaseNotes.AssemblyVersion]
)

Target "BuildApp" (fun _ ->
    MSBuildWithDefaults "Build" ["./Rothko.sln"]
    |> Log "AppBuild-Output: "
)

Target "UnitTests" (fun _ ->
    !! "./Tests/bin/Release/**/Tests.dll"
    |> xUnit2 (fun p -> 
            {p with 
                XmlOutput = true
                OutputDir = testResultsDir })
)

Target "Default" DoNothing

"Clean"
   ==> "AssemblyInfo"
   ==> "BuildApp"
   ==> "UnitTests"
   ==> "Default"

RunTargetOrDefault "Default"