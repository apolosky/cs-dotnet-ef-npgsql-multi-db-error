# I'm not sure why we're using this particular build, that's just what was made, so I kept it
# I am not opposed to swapping this out and using a different base a la https://github.com/sqitchers/docker-sqitch/blob/master/Dockerfile
FROM aleksandrvin/sqitch

COPY docker-sqitch.conf /root/.sqitch/

WORKDIR /flipr

COPY db2 /flipr

ENTRYPOINT []

CMD ["/bin/bash", "-c", "sqitch deploy db:pg://$POSTGRES_USER:$POSTGRES_PASSWORD@$POSTGRES_URI:5432/$POSTGRES_DB"]
