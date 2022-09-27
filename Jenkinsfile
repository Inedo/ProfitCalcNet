pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                sh '''cd ProfitCalcNet.Console
                dotnet build'''
            }

            post {
                success {
                    archiveArtifacts 'bin/Debug/net6.0/*.*'
                }
            }
        }
    }
}
