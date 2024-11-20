cd processorapp

export PATH="$PATH:/var/lib/jenkins/.dotnet/tools"
dotnet tool install -g dotnet-reportgenerator-globaltool

dotnet test --collect:"XPlat Code Coverage"
[ $? -eq 0 ] || exit 1

export guid=`ls -t1 processor.Tests/TestResults | tail -n 1`

reportgenerator -reports:"processor.Tests/TestResults/$guid/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html