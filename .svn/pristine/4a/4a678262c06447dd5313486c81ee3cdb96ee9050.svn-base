cd processorapp

export PATH="$PATH:/var/lib/jenkins/.dotnet/tools"

dotnet workload restore

dotnet build processor.UI
[ $? -eq 0 ] || exit 1

dotnet run --project processor.UI
[ $? -eq 0 ] || exit 1