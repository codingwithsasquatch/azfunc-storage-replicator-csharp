# Azure Function Storage Replicator - C<span>#</span>

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)



The `Storage Replicator` makes it incredibly easy to copy all changes to new Blobs inside of Azure Storage Account to another Azure Storage Acount. This sample demonstrates a simple use case of processing data from a given Blob using C#.

## How it works

For a `BlobTrigger` to work, you provide a path which dictates where the blobs are located inside your container, and can also help restrict the types of blobs you wish to return. For instance, you can set the path to `samples/{name}.png` to restrict the trigger to only the samples path and only blobs with ".png" at the end of their name.

## Learn more

<TODO> Documentation