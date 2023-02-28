<h1 align="center"> Bookmaker Integration </h1> <br>

<p align="center">
  This microservice is responsible for collecting all games for the next couple of days for each competition from each bookmaker. After collecting them, it propagates all the information to the Game Collector Service where the game information is stored.
</p>

## Table of Contents

- [Domain](#introduction)
- [Features](#features)
- [Roadmap](#roadmap)
- [Requirements](#requirements)
- [Quick Start](#quick-start)

## Domain

![Domain](https://github.com/skullizador/bookmaker-integration/blob/main/resources/domain.png)

## Features

Every bookmaker has the following features available:
* [x] Get Football competition data;

## Roadmap

* [x] Collect games for Primeira Liga in all bookmakers;
* [ ] Collect games for all competitions in Football;
* [ ] Collect games for all competitions in Basketball;
* [ ] Collect games for all competitions in Tennis;
* [ ] Collect games for all competitions in Hockey;
* [ ] Collect games for all competitions in Handball;
* [ ] Collect games for all competitions in MMA;
* [ ] Collect games for all competitions in Voleyball;
* [ ] Collect games for all competitions in Snooker;
* [ ] Collect games for all competitions in Rugby League;
* [ ] Collect games for all competitions in Rugby Union;
* [ ] Collect games for all competitions in Badminton;
* [ ] Collect games for all competitions in Cycling;
* [ ] Collect games for all competitions in Golf;
* [ ] Collect games for all competitions in Water Polo;
* [ ] Collect games for all competitions in Winter Sports;
* [ ] Collect games for all competitions in Motorsports;
* [ ] Collect games for all competitions in Formula1;

## Requirements
The application can be run locally or in a docker container, the requirements for each setup are listed below.

### Docker
* [Docker](https://www.docker.com/get-docker)

## Quick Start 
### Run Docker
TODO: Implement dockerfiles to run the application in a docker container.

First build the image:
```bash
$ docker-compose build
```

When ready, run it:
```bash
$ docker-compose up
```

Application will run by default on port `1234`