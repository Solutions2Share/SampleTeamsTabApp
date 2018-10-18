# SampleTeamsTabApp
Sample Teams Tab App with ngrok for blog post.

# Steps to run locally

## Prerequisites

* Install Git for windows: https://git-for-windows.github.io/

* Clone this repo:<br>
    ```
    git clone https://github.com/bastianjohn/SampleTeamsTabApp.git
    ```

* Install Visual Studio and launch it as an administrator

* Build the solution to download all configured NuGet packages

* (Only needed if wanting to run in Microsoft Teams)<br>
Install some sort of tunnelling service. These instructions assume you are using ngrok: https://ngrok.com/

## Steps to see the full app in Microsoft Teams

1. Begin your tunnelling service to get an https endpoint. 

	* Open a new **Command Prompt** window. 

	* Change to the directory that contains the ngrok.exe application. 

	* Run the command `ngrok http [port] --host-header=localhost` (you'll need the https endpoint for the bot registration) e.g.<br>
		```
		ngrok http [port] --host-header=localhost
		```

	* The ngrok application will fill the entire prompt window. Make note of the Forwarding address using https. This address is required in the next step. 

	* Minimize the ngrok Command Prompt window. It is no longer referenced in this lab, but it must remain running.

2. In Visual Studio click the play button (should be defaulted to running the Microsoft Edge configuration)

3. Update the manifest file in the following path: SampleTeamsApp\MSTeamsManifest\mainfest.json and replace the value `0f442812.ngrok.io` with the value where your ngrok is running.

3. Once complete, sideload your zipped manifest (From the Manifest folder) to a team as described here (open in a new browser tab): https://msdn.microsoft.com/en-us/microsoft-teams/sideload

Congratulations!!! You have just created and sideloaded your first Microsoft Teams app! Try adding a configurable tab.<br><br>
NOTE: Most of this sample app's functionality will now work.