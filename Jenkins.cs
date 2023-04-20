pipeline{
    agent any 
    environment {
        DIRECTORY_PATH= "Code Directory Path"
        TESTING_ENVIRONMENT= "Home Office"
        PRODUCTION_ENVIRONMENT= "Steph"
    }
    stages{
        stage('Build'){
            steps{
                echo "fetch the source code from the $DIRECTORY_PATH"
                echo "compile the code and generate any necessary artifacts"
            }
        }
        stage('Test'){
            steps{
                echo "Unit tests have started"
                echo ""
                echo "Unit tests have now completed!"
                echo ""
                echo "Integration tests have started"
                echo ""
                echo "Integration tests have now completed!"
            }
        }
        stage('Code Quality Check'){
            steps{
                echo "check the quality of the code"
            }
        }
        stage('Deploy'){
            steps{
                echo "deploy the application to $TESTING_ENVIRONMENT"
            }
        }
        stage('Approval'){
            steps{
                sleep 10 
            }
        }
        stage('Deploy to Production'){
            steps{
                echo "Deploy the code to $PRODUCTION_ENVIRONMENT"
            }
        }
    }
}