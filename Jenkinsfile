// comment
pipeline {
 agent any
 stages {
        stage('Checkout-git'){
               steps{
		cleanWs()
		git poll: true, url: 'git@github.com:OnlyDavies/SuperBank.git'
               }
        }
        stage('Build') {
            steps {
				sh '''
					bash -c "dotnet restore && dotnet build *.sln"
				'''

            }
        }
        stage('Tests') {
            steps {
            	sh '''
            		bash -c "dotnet test BankingTests/BankingTests.csproj"
                '''
            }
        }
        stage('Execute') {
            steps {
            	sh '''
            		bash -c "dotnet run --project SuperBank" 
                '''
            }
        }        
    }
}


