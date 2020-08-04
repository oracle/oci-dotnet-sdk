CODEGEN_PATH = $(shell pwd)
PROJECT_PATH = $(shell pwd)
UNIT_TEST_DIR = Commontests
UNIT_TEST_FILTER = Category=Unit
BUILD_OPTION = Debug

define HELP_MESSAGE
make build: 
    Build source code, with optional PROJECT_PATH and/or BUILD_OPTION argument.
    Example: 
        PROJECT_PATH=Audit will build source code in Audit project only.
        BUILD_OPTION=Release will build with Release configuration.
    Default will build source code for all services with Debug configuration.
make unit-test: 
    Run unit tests, with optional UNIT_TEST_FILTER argument to filter tests.
    Example: 
        UNIT_TEST_FILTER=DisplayName~ServicesTests will only run tests with "ServiceTests" in either namespace, class name, or test name.
    Default will run all unit tests.
endef

.PHONY: help 

export HELP_MESSAGE
help:
	@echo "$$HELP_MESSAGE"

build:
	@echo "Building .NET SDK"
	@(cd $(PROJECT_PATH) && dotnet build -c $(BUILD_OPTION))

unit-test:
	@echo "Running unit tests"
	@(cd $(UNIT_TEST_DIR) && dotnet test --filter $(UNIT_TEST_FILTER) --logger trx;LogFileName=unit_test.trx)