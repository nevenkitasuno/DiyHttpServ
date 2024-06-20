#!/bin/sh
exec dotnet run --project ./HttpServ --configuration Release -- "$@"