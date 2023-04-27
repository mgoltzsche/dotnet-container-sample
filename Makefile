IMAGE=dotnetapp

run: build
	docker run --rm $(IMAGE)

build:
	docker build --force-rm -t $(IMAGE) .
