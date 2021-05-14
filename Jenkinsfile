pipeline{
    agent any
    stages{
        stage("Checkout-git"){
            steps{
                git poll: true, url = 'git@github.com:OnlyDavies/SuperBank.git'
            }
           
        }
        stage("Build"){
            steps{
                sh '''
                    bash -c "dotnet restore && dotnet build *.sln"
                '''
            }
        stage("Execute"){
            steps{
                sh '''
                    bash -c "dotnet run --project SuperBank"
                '''
            }
           
        }
           
        }
    }
    post{
        always{
            echo "========always========"
        }
        success{
            echo "========pipeline executed successfully ========"
        }
        failure{
            echo "========pipeline execution failed========"
        }
    }
}