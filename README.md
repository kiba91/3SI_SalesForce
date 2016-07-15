# 3SI_SalesForce
force.com

Description: 
 - Build a development environment on force.com : 3SI
 - Integration Salesforce (SF) Rest API with a MVC web application to allow logged in user see their chatter, conversation and other user's profile
 - Otherwise, user can also update their Sales force profile directly on this web application

Purpose: 
 - Training the team work more with MVC web application
 - Develop application with Sales force REST API resources

Note:
 - Salesforce has disabled the TLS 1.0 security protocol from June 2016, some internet posts are not up-to-date. We have to change the TLS to 1.1, 1.2 version to ensure our http request can work well by adding the below code in Global.asax file: ServicePointManager.SecurityProtocol  = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
   Read more: https://help.salesforce.com/HTViewSolution?id=000221207&amp;language=en_US
 - If we set scope=full, the refesh_token is excluded from response string. We need add the refresh_token to scope on authorization request.
   Read more: https://help.salesforce.com/HTViewHelpDoc?id=remoteaccess_oauth_scopes.htm&language=en_US
 - force.com: cuongpv1991-74ye@force.com / Abcd1234