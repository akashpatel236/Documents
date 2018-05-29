

Hi Akash,


https://devcenter.heroku.com/articles/java-webapp-runner#create-a-procfile

Create any project in maven..

Edit POM.xml with

<build>
    <plugins>
        ...
        <plugin>
            <groupId>org.apache.maven.plugins</groupId>
            <artifactId>maven-dependency-plugin</artifactId>
            <version>3.0.2</version>
            <executions>
                <execution>
                    <phase>package</phase>
                    <goals><goal>copy</goal></goals>
                    <configuration>
                        <artifactItems>
                            <artifactItem>
                                <groupId>com.github.jsimone</groupId>
                                <artifactId>webapp-runner</artifactId>
                                <version>8.5.31.0</version>
                                <destFileName>webapp-runner.jar</destFileName>
                            </artifactItem>
                        </artifactItems>
                    </configuration>
                </execution>
            </executions>
        </plugin>
    </plugins>
</build>

Build that application again -> mvn clean package


Deploy using Heroku..

java -jar target/dependency/webapp-runner.jar --port 8087 target/*.war


Commit your changes to Git:

git init
git add .
git commit -m "Ready to deploy"


Login to heroku

then heroku create 

push it to git.

git push heroku master

//to setup cli for heroku deployment
heroku plugins:install heroku-cli-deploy


C:\techm_workspace\TIEInterface>heroku apps:info
 !    heroku-cli: update available from 6.15.5-1f03166 to 6.99.0-ec9edad
=== murmuring-crag-48450
Auto Cert Mgmt: false
Dynos:
Git URL:        https://git.heroku.com/murmuring-crag-48450.git
Owner:          akashpatel236@gmail.com
Region:         us
Repo Size:      8 MB
Slug Size:      58 MB
Stack:          heroku-16
Web URL:        https://murmuring-crag-48450.herokuapp.com/


======================
Deploy application to heroku

heroku war:deploy C:\techm_workspace\TIEInterface\target\TIEInterface.war --app TIEInterface

//app info

heroku appps:info

C:\techm_workspace\TIEInterface>heroku apps:info -a  murmuring-crag-48450
 !    heroku-cli: update available from 6.15.5-1f03166 to 6.99.0-ec9edad
=== murmuring-crag-48450
Auto Cert Mgmt: false
Dynos:
Git URL:        https://git.heroku.com/murmuring-crag-48450.git
Owner:          akashpatel236@gmail.com
Region:         us
Repo Size:      8 MB
Slug Size:      58 MB
Stack:          heroku-16
Web URL:        https://murmuring-crag-48450.herokuapp.com/

# heroku war:deploy C:\techm_workspace\TIEInterface\target\TIEInterface.war --app  murmuring-crag-48450


Deployed on : https://murmuring-crag-48450.herokuapp.com/



heroku war:deploy C:\techm_workspace\TIEInterface\target\TIEInterface.war --app TIEInterface

heroku war:deploy C:\oxygen_workspace\tie-application-1\target\TIEInterface.war --app  tie-application-1

heroku war:deploy C:\oxygen_workspace\myProject\target\TIEInterface.war --app  tie-application

java -jar target/dependency/webapp-runner.jar --port 8087 target/*.war

Regards,
Akash Patel
 - Software Engineer at Tech Mahindra, Pune


 
 ==================== Database
 
 
 
 https://devcenter.heroku.com/articles/heroku-postgresql#provisioning-heroku-postgres
 
 
 heroku addons:create heroku-postgresql:hobby-dev -a tie-application
 
 or else   heroku addons:create heroku-postgresql:<PLAN_NAME>    ... i.e. plan name : hobby-dev
 
 heroku addons
 
 
 heroku pg:info -a app_name
 
 
 1234
 5432
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 