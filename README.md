
## My first SAM app
Taken from article: https://itnext.io/creating-aws-lambda-applications-with-sam-dd13258c16dd


### Main Commands

`sam package --template-file template.yaml --output-template-file package.yaml --s3-bucket test-sam-deploy-bucket`

`sam deploy --template-file package.yaml --stack-name my-sam-application --capabilities CAPABILITY_IAM`

### Useful References

What you need is: 
 - CloudFormation yaml specification;
 - SAM yaml specification;
 - AWS SDK documentation for Lambda Function code;

links:
- [SAM specification](https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md)
- [CloudFormation resource types](https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html)
- [CloudFormation instrinsict function](https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference.html)

- [Policy Template](https://github.com/awslabs/serverless-application-model/blob/master/docs/policy_templates.rst)
- [All policy Template](https://github.com/awslabs/serverless-application-model/blob/develop/examples/2016-10-31/policy_templates/all_policy_templates.yaml)
- [All SAM policies Specifications](https://github.com/awslabs/serverless-application-model/blob/develop/samtranslator/policy_templates_data/policy_templates.json)
- [Java and C# languages](https://github.com/awslabs/aws-sam-cli/blob/develop/docs/advanced_usage.rst)
