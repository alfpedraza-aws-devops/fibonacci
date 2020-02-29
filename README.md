# fibonacci

Exposes a service to get the *nth* element of the fibonacci sequence recursively. 

## Usage

To execute this service, deploy it to a web server and then execute a `curl` using http://url.of.this.service/api/fibonacci/${ELEMENT} where `${ELEMENT}` is an integer representing the index of the element in the Fibonacci sequence to get. The script below gets the 40th element in the Fibonacci sequence.


### Example

```
curl http://url.of.this.service/api/fibonacci/40
```

## Cluster Autoscaler Test

This service is used to generate a heavy processing load on the CPU of the underlying machine running it. Because of this intense processing load, it's also used for a cluster autoscaler test.

### Example 
To mention an example, generating the *40th* element in the Fibonacci sequence takes about 1 second on a `ubuntu/images/hvm-ssd/ubuntu-xenial-16.04-amd64-server-20200129` machine on AWS. This AWS virtual machine has 2 `Intel(R) Xeon(R) CPU E5-2676 v3` vCPU's running at `2.40GHz` each.

## Cluster Autoscaler
So, if the number of requests increases, the CPU will be busy almost all the time on the machine hosting this service (CPU utilization ~~ 100%). The `cluster autoscaler` service on Kubernetes will notice this metric is avobe of the target utilization and will spin up an additional AWS virtual machine.

The additional virtual machine is part of an AWS autoscale group which contains a launch configuration. This launch configuration will let the new virtual machine know how to join to the Kubernetes cluster.