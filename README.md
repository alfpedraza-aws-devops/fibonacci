# fibonacci

## Description

Exposes a service to get the *nth* element of the Fibonacci sequence recursively. 

## Usage

Execute a `curl` using http://url.of.this.service/api/fibonacci/${ELEMENT} where `${ELEMENT}` is an integer representing the index of the element in the Fibonacci sequence.

### Example:

The script below gets the 40th element in the Fibonacci sequence.

```
curl http://url.of.this.service/api/fibonacci/40
```

## Role

This service is used to generate a high CPU load on the machine hosting it due to its recursive implementation of the Fibonacci sequence algorithm. 

The role of this service in the _Kubernetes Cluster Autoscaler Test_ application is precisely that, generating a lot of CPU load on the Kubernetes node machines, so the Kubernetes `cluster autoscaler` service creates more nodes in the cluster to meet the CPU demand. 

## Further Development

* There are no pending items here.