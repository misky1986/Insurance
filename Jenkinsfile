pipeline {
  agent {
    docker {
      image 'microsoft/aspnetcore:2.0'
      args '- p 80:80'
    }
    
  }
  stages {
    stage('Build') {
      steps {
        sh 'dotnet restore'
      }
    }
  }
}