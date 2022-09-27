pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                sh '''cd ProfiteCalcNet.Console
                dotnet build'''
            }

            post {
                success {
                    archiveArtifacts 'ProfiteCalcNet.Console/bin/Debug/net6.0/*.*'
                }
            }
        }
    }
}
